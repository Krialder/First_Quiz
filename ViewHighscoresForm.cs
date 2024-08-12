using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace QuizApplication
{
    public partial class ViewHighscoresForm : Form
    {
        private string connectionString;
        private MainForm mainForm;

        public ViewHighscoresForm(string connectionString, MainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.mainForm = mainForm;
            LoadHighscores();
        }

        private void LoadHighscores()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Load normal mode highscores
                var normalHighscores = new MySqlDataAdapter("SELECT Name, Points, SEC_TO_TIME(TimeTaken) AS TimeTaken, Mode FROM Highscores WHERE Mode = 'normal' ORDER BY Points DESC, TimeTaken ASC LIMIT 10", connection);
                var normalTable = new DataTable();
                normalHighscores.Fill(normalTable);
                dgvNormalHighscores.DataSource = normalTable;
                SetColumnsReadOnly(dgvNormalHighscores);

                // Load hell mode highscores
                var hellHighscores = new MySqlDataAdapter("SELECT Name, Points, SEC_TO_TIME(TimeTaken) AS TimeTaken, Mode FROM Highscores WHERE Mode = 'hell' ORDER BY Points DESC, TimeTaken ASC LIMIT 10", connection);
                var hellTable = new DataTable();
                hellHighscores.Fill(hellTable);
                dgvHellHighscores.DataSource = hellTable;
                SetColumnsReadOnly(dgvHellHighscores);

                // Load free mode normal highscores
                var freeModeNormalHighscores = new MySqlDataAdapter("SELECT Name, Points, SEC_TO_TIME(TimeTaken) AS TimeTaken, Mode FROM Highscores WHERE Mode = 'normal (Free Mode)' ORDER BY Points DESC, TimeTaken ASC LIMIT 10", connection);
                var freeModeNormalTable = new DataTable();
                freeModeNormalHighscores.Fill(freeModeNormalTable);
                dgvFreeModeNormalHighscores.DataSource = freeModeNormalTable;
                SetColumnsReadOnly(dgvFreeModeNormalHighscores);

                // Load free mode hell highscores
                var freeModeHellHighscores = new MySqlDataAdapter("SELECT Name, Points, SEC_TO_TIME(TimeTaken) AS TimeTaken, Mode FROM Highscores WHERE Mode = 'hell (Free Mode)' ORDER BY Points DESC, TimeTaken ASC LIMIT 10", connection);
                var freeModeHellTable = new DataTable();
                freeModeHellHighscores.Fill(freeModeHellTable);
                dgvFreeModeHellHighscores.DataSource = freeModeHellTable;
                SetColumnsReadOnly(dgvFreeModeHellHighscores);
            }
        }

        private void SetColumnsReadOnly(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.ReadOnly = true;
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

