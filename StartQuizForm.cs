using System;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class StartQuizForm : Form
    {
        private string connectionString;
        private MainForm mainForm;

        public StartQuizForm(string connectionString, MainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.mainForm = mainForm;
        }

        // Event handler for the Normal button
        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            var quizInterfaceForm = new QuizInterfaceForm("normal", connectionString, false, mainForm);
            quizInterfaceForm.ShowDialog();
            this.Close(); // Close the current form after quiz interface form is closed
        }

        // Event handler for the Hell button
        private void btnHell_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            var quizInterfaceForm = new QuizInterfaceForm("hell", connectionString, false, mainForm);
            quizInterfaceForm.ShowDialog();
            this.Close(); // Close the current form after quiz interface form is closed
        }

        // Event handler for the Free Mode button
        private void btnFreeMode_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            var quizInterfaceForm = new QuizInterfaceForm("free", connectionString, true, mainForm);
            quizInterfaceForm.ShowDialog();
            this.Close(); // Close the current form after quiz interface form is closed
        }

        // Event handler for the Return button
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
            mainForm.Show(); // Show the main form
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
