using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuizApplication
{
    public partial class AddQuestionForm : Form
    {
        private string connectionString;
        private MainForm mainForm;

        public AddQuestionForm(string connectionString, MainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.mainForm = mainForm;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve and trim the input values from the form fields
            string questionText = txtQuestionText.Text.Trim();
            string correctAnswer = txtCorrectAnswer.Text.Trim();
            string wrongAnswer1 = txtWrongAnswer1.Text.Trim();
            string wrongAnswer2 = txtWrongAnswer2.Text.Trim();
            string wrongAnswer3 = txtWrongAnswer3.Text.Trim();
            string mode = cbMode.SelectedItem?.ToString();

            // Validate inputs: ensure the question text contains letters and ends with a question mark
            if (string.IsNullOrEmpty(questionText) || !questionText.Any(char.IsLetter))
            {
                MessageBox.Show("The question must contain letters.");
                return; // Exit the method if validation fails
            }

            if (!questionText.EndsWith("?"))
            {
                MessageBox.Show("The question must end with a '?'.");
                return; // Exit the method if validation fails
            }

            // Ensure all answer fields are filled in
            if (string.IsNullOrEmpty(correctAnswer) || string.IsNullOrEmpty(wrongAnswer1) ||
                string.IsNullOrEmpty(wrongAnswer2) || string.IsNullOrEmpty(wrongAnswer3))
            {
                MessageBox.Show("Please fill in all answer fields.");
                return; // Exit the method if validation fails
            }

            // Validate mode selection
            if (string.IsNullOrEmpty(mode))
            {
                MessageBox.Show("Please select a mode.");
                return; // Exit the method if validation fails
            }

            // Check for duplicate answers (case insensitive)
            var answers = new List<string> { correctAnswer, wrongAnswer1, wrongAnswer2, wrongAnswer3 };
            var normalizedAnswers = answers.Select(a => a.ToLower()).ToList();
            if (normalizedAnswers.Count != normalizedAnswers.Distinct().Count())
            {
                MessageBox.Show("Answers must be unique.");
                return; // Exit the method if validation fails
            }

            try
            {
                // Insert the question and answers into the database
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open(); // Open the database connection

                    // Insert the question into the Questions table and retrieve the new question ID
                    var command = new MySqlCommand(
                        "INSERT INTO Questions (Text, CorrectAnswer, Mode) VALUES (@Text, @CorrectAnswer, @Mode); SELECT LAST_INSERT_ID();",
                        connection
                    );
                    command.Parameters.AddWithValue("@Text", questionText);
                    command.Parameters.AddWithValue("@CorrectAnswer", correctAnswer);
                    command.Parameters.AddWithValue("@Mode", mode);
                    int questionId = Convert.ToInt32(command.ExecuteScalar());

                    // Insert each wrong answer into the WrongAnswers table with the new question ID
                    var wrongAnswers = new[] { wrongAnswer1, wrongAnswer2, wrongAnswer3 };
                    foreach (var wrongAnswer in wrongAnswers)
                    {
                        var wrongAnswerCommand = new MySqlCommand(
                            "INSERT INTO WrongAnswers (QuestionId, Answer) VALUES (@QuestionId, @Answer)",
                            connection
                        );
                        wrongAnswerCommand.Parameters.AddWithValue("@QuestionId", questionId);
                        wrongAnswerCommand.Parameters.AddWithValue("@Answer", wrongAnswer);
                        wrongAnswerCommand.ExecuteNonQuery();
                    }
                }

                // Show a success message after adding the question and answers to the database
                MessageBox.Show("Question added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        // Event handler for the Return button click
        private void btnReturn_Click(object sender, EventArgs e)
        {
            mainForm.Show(); // Show the main form
            this.Close(); // Close the current form
        }

        // Override the OnFormClosed method to ensure proper cleanup
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            mainForm.Show(); // Show the main form
            Dispose(true); // Dispose of resources
        }
    }
}
