using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class MainForm : Form
    {
        private string connectionString = "Server=192.168.2.150;database=kde_test;User ID=kde;Password=kde";

        public MainForm()
        {
            InitializeComponent();
            InitializeDatabase(); // Initialize the database when the application starts
        }

        // Method to initialize the database
        private void InitializeDatabase()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open(); // Open the database connection

                // SQL command to create the necessary tables if they don't exist
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Highscores (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    Name VARCHAR(255) NOT NULL,
                    Points INT NOT NULL,
                    Mode VARCHAR(50) NOT NULL,
                    TimeTaken DOUBLE NOT NULL
                );
                CREATE TABLE IF NOT EXISTS Questions (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    Text TEXT NOT NULL,
                    CorrectAnswer TEXT NOT NULL,
                    Mode VARCHAR(50) NOT NULL
                );
                CREATE TABLE IF NOT EXISTS WrongAnswers (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    QuestionId INT,
                    Answer TEXT NOT NULL,
                    FOREIGN KEY (QuestionId) REFERENCES Questions(id)
                );";

                using (var command = new MySqlCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery(); // Execute the command to create tables
                }

                // Check if there are any questions in the database
                string checkQuestionsQuery = "SELECT COUNT(*) FROM Questions";
                using (var command = new MySqlCommand(checkQuestionsQuery, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 0)
                    {
                        // If no questions exist, insert initial questions
                        InsertInitialQuestions();
                    }
                }
            }
        }

        // Method to insert initial questions into the database
        private void InsertInitialQuestions()
        {
            var normalQuestions = new List<Question>
            {
                new Question("What does AI stand for?", "Artificial Intelligence", new List<string> {"Automated Intelligence", "Analog Intelligence", "Advanced Intelligence"}),
                new Question("Which of the following is a common programming language used in AI development?", "Python", new List<string>{ "HTML", "CSS", "XML" })
            };

            var hellQuestions = new List<Question>
            {
                new Question("What is the primary function of a convolutional layer in a Convolutional Neural Network (CNN)?", "To apply filters to the input data to extract features", new List<string>{ "To fully connect all neurons in one layer to all neurons in the next layer", "To reduce the dimensionality of the data", "To perform backpropagation" })
            };

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open(); // Open the database connection

                // Insert normal questions into the database
                foreach (var question in normalQuestions)
                {
                    InsertQuestion(question, "normal", connection);
                }

                // Insert hell questions into the database
                foreach (var question in hellQuestions)
                {
                    InsertQuestion(question, "hell", connection);
                }
            }
        }

        // Method to insert a question and its wrong answers into the database
        private void InsertQuestion(Question question, string mode, MySqlConnection connection)
        {
            // SQL command to insert a question into the Questions table
            string insertQuestionQuery = "INSERT INTO Questions (Text, CorrectAnswer, Mode) VALUES (@Text, @CorrectAnswer, @Mode); SELECT LAST_INSERT_ID();";
            using (var command = new MySqlCommand(insertQuestionQuery, connection))
            {
                command.Parameters.AddWithValue("@Text", question.Text);
                command.Parameters.AddWithValue("@CorrectAnswer", question.CorrectAnswer);
                command.Parameters.AddWithValue("@Mode", mode);
                int questionId = Convert.ToInt32(command.ExecuteScalar()); // Execute the command and get the inserted question ID

                // Insert each wrong answer into the WrongAnswers table
                foreach (var wrongAnswer in question.PossibleWrongAnswers)
                {
                    string insertWrongAnswerQuery = "INSERT INTO WrongAnswers (QuestionId, Answer) VALUES (@QuestionId, @Answer)";
                    using (var wrongAnswerCommand = new MySqlCommand(insertWrongAnswerQuery, connection))
                    {
                        wrongAnswerCommand.Parameters.AddWithValue("@QuestionId", questionId);
                        wrongAnswerCommand.Parameters.AddWithValue("@Answer", wrongAnswer);
                        wrongAnswerCommand.ExecuteNonQuery(); // Execute the command to insert the wrong answer
                    }
                }
            }
        }

        // Event handler for the Start Quiz button
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            var startQuizForm = new StartQuizForm(connectionString, this);
            this.Hide(); // Hide the current form
            startQuizForm.Show(); // Show the start quiz form
        }

        // Event handler for the Start Free Mode button
        private void btnStartFreeMode_Click(object sender, EventArgs e)
        {
            var startFreeModeForm = new StartFreeModeForm(connectionString, this);
            this.Hide(); // Hide the current form
            startFreeModeForm.Show(); // Show the start free mode form
        }

        // Event handler for the View Highscores button
        private void btnViewHighscores_Click(object sender, EventArgs e)
        {
            var viewHighscoresForm = new ViewHighscoresForm(connectionString, this);
            this.Hide(); // Hide the current form
            viewHighscoresForm.Show(); // Show the view highscores form
        }

        // Event handler for the Add a Question button
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            var addQuestionForm = new AddQuestionForm(connectionString, this);
            this.Hide(); // Hide the current form
            addQuestionForm.Show(); // Show the add question form
        }

        // Event handler for the Quit button
        private void btnQuit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to quit?", "Confirm Quit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Handle the FormClosing event to ensure all resources are disposed
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
