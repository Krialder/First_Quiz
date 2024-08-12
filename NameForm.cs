using System;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class NameForm : Form
    {
        public string PlayerName { get; private set; }

        public NameForm()
        {
            InitializeComponent();
        }

        // Event handler for the OK button click
        private void btnOk_Click(object sender, EventArgs e)
        {
            PlayerName = txtName.Text.Trim();
            if (string.IsNullOrEmpty(PlayerName))
            {
                MessageBox.Show("Please enter your name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        // Event handler for the Cancel button click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Override the OnFormClosed method to ensure proper cleanup
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Dispose(true); // Dispose of resources
        }
    }
}
