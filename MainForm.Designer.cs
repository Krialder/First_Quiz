namespace QuizApplication
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Button btnStartFreeMode;
        private System.Windows.Forms.Button btnViewHighscores;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnQuit;

        // Method to dispose the resources being used
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Method to initialize the components of the form
        private void InitializeComponent()
        {
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.btnStartFreeMode = new System.Windows.Forms.Button();
            this.btnViewHighscores = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Location = new System.Drawing.Point(50, 30);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(200, 40);
            this.btnStartQuiz.TabIndex = 0;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // btnStartFreeMode
            // 
            this.btnStartFreeMode.Location = new System.Drawing.Point(50, 80);
            this.btnStartFreeMode.Name = "btnStartFreeMode";
            this.btnStartFreeMode.Size = new System.Drawing.Size(200, 40);
            this.btnStartFreeMode.TabIndex = 1;
            this.btnStartFreeMode.Text = "Start Free Mode";
            this.btnStartFreeMode.UseVisualStyleBackColor = true;
            this.btnStartFreeMode.Click += new System.EventHandler(this.btnStartFreeMode_Click);
            // 
            // btnViewHighscores
            // 
            this.btnViewHighscores.Location = new System.Drawing.Point(50, 130);
            this.btnViewHighscores.Name = "btnViewHighscores";
            this.btnViewHighscores.Size = new System.Drawing.Size(200, 40);
            this.btnViewHighscores.TabIndex = 2;
            this.btnViewHighscores.Text = "View Highscores";
            this.btnViewHighscores.UseVisualStyleBackColor = true;
            this.btnViewHighscores.Click += new System.EventHandler(this.btnViewHighscores_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(50, 180);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(200, 40);
            this.btnAddQuestion.TabIndex = 3;
            this.btnAddQuestion.Text = "Add a Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(50, 230);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(200, 40);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnViewHighscores);
            this.Controls.Add(this.btnStartFreeMode);
            this.Controls.Add(this.btnStartQuiz);
            this.Name = "MainForm";
            this.Text = "Quiz Application";
            this.ResumeLayout(false);
        }
    }
}
