using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuizApplication
{
    public partial class QuizInterfaceForm : Form
    {
        private string mode;
        private bool isFreeMode;
        private Timer questionTimer;
        private Timer fullQuizTimer;
        private int questionTimeRemaining;
        private int fullQuizTimeRemaining;
        private int totalScore;
        private List<int> scores;
        private List<Question> questions;
        private List<string> answerOptions;
        private string connectionString;
        private MainForm mainForm;
        private int currentQuestionIndex;
        private RevealAnswer revealJoker;
        private FiftyFiftyJoker fiftyFiftyJoker;

        public QuizInterfaceForm(string mode, string connectionString, bool isFreeMode, MainForm mainForm)
        {
            InitializeComponent();
            this.mode = mode;
            this.connectionString = connectionString;
            this.isFreeMode = isFreeMode;
            this.mainForm = mainForm;
            this.revealJoker = new RevealAnswer();
            this.fiftyFiftyJoker = new FiftyFiftyJoker();

            if (isFreeMode)
            {
                btnFiftyFifty.Visible = false; // Hide the button in free mode
                txtFreeModeAnswer.KeyDown += txtFreeModeAnswer_KeyDown; // Add KeyDown event handler
            }

            InitializeQuiz();
            this.FormClosing += QuizInterfaceForm_FormClosing; // Add FormClosing event handler
        }

        // Method to handle KeyDown event for txtFreeModeAnswer
        private void txtFreeModeAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key press
            }
        }

        // Override ProcessCmdKey to disable Enter key for the whole form
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (isFreeMode && keyData == Keys.Enter)
            {
                return true; // Handle the Enter key press, do nothing
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Method to initialize the quiz
        private void InitializeQuiz()
        {
            questions = GetQuestionsFromDatabase(mode);
            questions = GetRandomElements(questions, 10); // Limit to 10 questions

            questionTimeRemaining = mode == "normal" ? 20 : 10;
            fullQuizTimeRemaining = mode == "normal" ? 2 * 60 : 1 * 60; // Convert to seconds
            currentQuestionIndex = 0;
            totalScore = 0;
            scores = new List<int>();

            questionTimer = new Timer();
            questionTimer.Interval = 1000; // 1 second intervals
            questionTimer.Tick += QuestionTimer_Tick;

            fullQuizTimer = new Timer();
            fullQuizTimer.Interval = 1000; // 1 second intervals
            fullQuizTimer.Tick += FullQuizTimer_Tick;

            questionTimer.Start();
            fullQuizTimer.Start();

            LoadNextQuestion();
        }

        // Method to load the next question
        private void LoadNextQuestion()
        {
            if (currentQuestionIndex >= questions.Count)
            {
                EndQuiz();
                return;
            }

            var question = questions[currentQuestionIndex];
            lblQuestionText.Text = $"Question {currentQuestionIndex + 1}: {question.Text}";

            if (!isFreeMode)
            {
                answerOptions = GenerateAnswers(question.CorrectAnswer, question.PossibleWrongAnswers);
                rbOption1.Text = answerOptions[0];
                rbOption2.Text = answerOptions[1];
                rbOption3.Text = answerOptions[2];
                rbOption4.Text = answerOptions[3];
                rbOption1.Checked = rbOption2.Checked = rbOption3.Checked = rbOption4.Checked = false;
                rbOption1.Visible = rbOption2.Visible = rbOption3.Visible = rbOption4.Visible = true;
                txtFreeModeAnswer.Visible = false;
            }
            else
            {
                txtFreeModeAnswer.Text = string.Empty;
                txtFreeModeAnswer.Enabled = true; // Re-enable the answer field for the next question
                rbOption1.Visible = rbOption2.Visible = rbOption3.Visible = rbOption4.Visible = false;
                txtFreeModeAnswer.Visible = true;
            }

            progressBar.Value = (int)(((double)(currentQuestionIndex + 1) / questions.Count) * 100);
            lblQuestionCount.Text = $"Question {currentQuestionIndex + 1} of {questions.Count}";

            // Restart timers for the new question
            questionTimer.Start();
            fullQuizTimer.Start();
        }

        // Event handler for the question timer tick
        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            questionTimeRemaining--;
            lblQuestionTimer.Text = $"Time Remaining: {questionTimeRemaining} seconds";
            if (questionTimeRemaining <= 0)
            {
                EvaluateAnswer(null);
            }
        }

        // Event handler for the full quiz timer tick
        private void FullQuizTimer_Tick(object sender, EventArgs e)
        {
            fullQuizTimeRemaining--;
            lblFullQuizTimer.Text = $"Quiz Time Remaining: {fullQuizTimeRemaining / 60} minutes {fullQuizTimeRemaining % 60} seconds";
            if (fullQuizTimeRemaining <= 0)
            {
                EndQuiz();
            }
        }

        // Event handler for the Submit button click
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string selectedOption = isFreeMode ? txtFreeModeAnswer.Text.Trim() : GetSelectedOption();
            EvaluateAnswer(selectedOption);
        }

        // Event handler for the Skip button click
        private void btnSkip_Click(object sender, EventArgs e)
        {
            EvaluateAnswer(null);
        }

        // Event handler for the Reveal Answer button click
        private void btnRevealAnswer_Click(object sender, EventArgs e)
        {
            if (revealJoker.UseJoker())
            {
                var correctAnswer = questions[currentQuestionIndex].CorrectAnswer;

                if (isFreeMode)
                {
                    txtFreeModeAnswer.Text = correctAnswer;
                    txtFreeModeAnswer.Enabled = false;

                    // Disable the Reveal Answer button after use
                    btnRevealAnswer.Enabled = false;

                    // Automatically evaluate the answer
                    EvaluateAnswer(correctAnswer);
                }
                else
                {
                    // Ensure all options are visible before revealing the correct one
                    // Now only show the options that are still visible after 50/50 joker is used
                    if (rbOption1.Visible && rbOption1.Text == correctAnswer) rbOption1.Checked = true;
                    if (rbOption2.Visible && rbOption2.Text == correctAnswer) rbOption2.Checked = true;
                    if (rbOption3.Visible && rbOption3.Text == correctAnswer) rbOption3.Checked = true;
                    if (rbOption4.Visible && rbOption4.Text == correctAnswer) rbOption4.Checked = true;

                    // Disable the Reveal Answer button after use
                    btnRevealAnswer.Enabled = false;

                    // Automatically evaluate the answer
                    EvaluateAnswer(correctAnswer);
                }
            }
        }

        // Event handler for the Fifty-Fifty button click
        private void btnFiftyFifty_Click(object sender, EventArgs e)
        {
            if (fiftyFiftyJoker.UseJoker())
            {
                ApplyFiftyFiftyJoker();

                // Disable the Fifty-Fifty button after use
                btnFiftyFifty.Enabled = false;
            }
        }

        // Method to apply fifty-fifty joker
        private void ApplyFiftyFiftyJoker()
        {
            var question = questions[currentQuestionIndex];
            var incorrectOptions = answerOptions.Where(opt => !opt.Equals(question.CorrectAnswer)).ToList();
            var random = new Random();
            incorrectOptions = GetRandomElements(incorrectOptions, 2);

            foreach (var option in incorrectOptions)
            {
                if (rbOption1.Text == option) rbOption1.Visible = false;
                if (rbOption2.Text == option) rbOption2.Visible = false;
                if (rbOption3.Text == option) rbOption3.Visible = false;
                if (rbOption4.Text == option) rbOption4.Visible = false;
            }
        }

        // Event handler for the Return button click
        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Stop timers to ensure the quiz does not continue in the background
            questionTimer.Stop();
            fullQuizTimer.Stop();

            // Ensure timers are disposed
            questionTimer.Dispose();
            fullQuizTimer.Dispose();

            this.Hide(); // Hide the current form

            if (isFreeMode)
            {
                var startFreeModeForm = new StartFreeModeForm(connectionString, mainForm);
                startFreeModeForm.ShowDialog();
            }
            else
            {
                var startQuizForm = new StartQuizForm(connectionString, mainForm);
                startQuizForm.ShowDialog();
            }

            this.Close(); // Ensure the current form is closed after the dialog
        }

        // Method to get the selected option
        private string GetSelectedOption()
        {
            if (rbOption1.Checked) return rbOption1.Text;
            if (rbOption2.Checked) return rbOption2.Text;
            if (rbOption3.Checked) return rbOption3.Text;
            if (rbOption4.Checked) return rbOption4.Text;
            return null;
        }

        // Method to evaluate the selected answer
        private void EvaluateAnswer(string selectedAnswer)
        {
            // Stop the timers when an answer is evaluated
            questionTimer.Stop();
            fullQuizTimer.Stop();

            var question = questions[currentQuestionIndex];
            if (selectedAnswer != null && selectedAnswer.Equals(question.CorrectAnswer, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show($"Correct! \"{question.CorrectAnswer}\" is the Answer! ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int score = (mode == "normal" ? 15 : 10) + questionTimeRemaining;
                totalScore += score;
                scores.Add(score);
            }
            else
            {
                MessageBox.Show($"Wrong! Correct answer: {question.CorrectAnswer}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                totalScore += mode == "normal" ? 0 : -2;
                scores.Add(mode == "normal" ? 0 : -2);
            }

            currentQuestionIndex++;
            questionTimeRemaining = mode == "normal" ? 20 : 10;
            LoadNextQuestion();
        }

        // Method to end the quiz
        private void EndQuiz()
        {
            fullQuizTimer.Stop();
            questionTimer.Stop();

            var nameForm = new NameForm();
            if (nameForm.ShowDialog() == DialogResult.OK)
            {
                var name = nameForm.PlayerName;
                SaveHighscore(name, totalScore, mode + (isFreeMode ? " (Free Mode)" : ""), TimeSpan.FromSeconds(35 * 60 - fullQuizTimeRemaining));
            }

            MessageBox.Show($"Your total score is: {totalScore}\nTime taken: {2 * 60 - fullQuizTimeRemaining} seconds", "Quiz Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainForm.Show();
            this.Close();
        }

        // Method to save the highscore to the database
        private void SaveHighscore(string name, int score, string mode, TimeSpan timeTaken)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO Highscores (Name, Points, Mode, TimeTaken) VALUES (@Name, @Points, @Mode, @TimeTaken)", connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Points", score);
                command.Parameters.AddWithValue("@Mode", mode);
                command.Parameters.AddWithValue("@TimeTaken", timeTaken.TotalSeconds);
                command.ExecuteNonQuery();
            }
        }

        // Method to retrieve questions from the database
        private List<Question> GetQuestionsFromDatabase(string mode)
        {
            var questions = new List<Question>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var command = new MySqlCommand("SELECT q.id, q.Text, q.CorrectAnswer, w.Answer FROM Questions q LEFT JOIN WrongAnswers w ON q.id = w.QuestionId WHERE q.Mode = @Mode", connection);
                command.Parameters.AddWithValue("@Mode", mode);
                using (var reader = command.ExecuteReader())
                {
                    var questionDict = new Dictionary<int, Question>();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string text = reader.GetString(1);
                        string correctAnswer = reader.GetString(2);
                        string wrongAnswer = reader.GetString(3);

                        if (!questionDict.ContainsKey(id))
                        {
                            questionDict[id] = new Question(text, correctAnswer, new List<string>());
                        }

                        questionDict[id].PossibleWrongAnswers.Add(wrongAnswer);
                    }

                    questions = questionDict.Values.ToList();
                }
            }

            return questions;
        }

        // Method to get random elements from a list
        private List<T> GetRandomElements<T>(List<T> list, int count)
        {
            var selected = new List<T>();
            var random = new Random();

            while (selected.Count < count && selected.Count < list.Count)
            {
                int index = random.Next(list.Count);
                if (!selected.Contains(list[index]))
                {
                    selected.Add(list[index]);
                }
            }

            return selected;
        }

        // Method to generate answers for a question
        private List<string> GenerateAnswers(string correctAnswer, List<string> possibleWrongAnswers)
        {
            var answers = new List<string> { correctAnswer };
            var wrongAnswers = GetRandomElements(possibleWrongAnswers, 3);
            answers.AddRange(wrongAnswers);
            return answers.OrderBy(x => Guid.NewGuid()).ToList(); // Shuffle the answers
        }

        // Handle the FormClosing event to ensure all resources are disposed
        private void QuizInterfaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            questionTimer?.Dispose();
            fullQuizTimer?.Dispose();
            if (mainForm != null && !mainForm.Visible)
            {
                mainForm.Show();
            }
            Dispose(true); // Dispose of resources
        }

        private void txtFreeModeAnswer_TextChanged(object sender, EventArgs e)
        {
        }

        private void QuizInterfaceForm_Load(object sender, EventArgs e)
        {

        }
    }
}