namespace QuizApplication
{
    partial class QuizInterfaceForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Label lblQuestionTimer;
        private System.Windows.Forms.Label lblFullQuizTimer;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtFreeModeAnswer;
        private System.Windows.Forms.RadioButton rbOption1;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRevealAnswer;
        private System.Windows.Forms.Button btnFiftyFifty;
        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Panel answerPanel;
        private System.Windows.Forms.Label lblQuestionCount;

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
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.lblQuestionTimer = new System.Windows.Forms.Label();
            this.lblFullQuizTimer = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtFreeModeAnswer = new System.Windows.Forms.TextBox();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.rbOption4 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRevealAnswer = new System.Windows.Forms.Button();
            this.btnFiftyFifty = new System.Windows.Forms.Button();
            this.questionPanel = new System.Windows.Forms.Panel();
            this.answerPanel = new System.Windows.Forms.Panel();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.questionPanel.SuspendLayout();
            this.answerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Location = new System.Drawing.Point(15, 16);
            this.lblQuestionText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestionText.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(73, 13);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Text = "Question Text";
            // 
            // lblQuestionTimer
            // 
            this.lblQuestionTimer.AutoSize = true;
            this.lblQuestionTimer.Location = new System.Drawing.Point(15, 65);
            this.lblQuestionTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestionTimer.Name = "lblQuestionTimer";
            this.lblQuestionTimer.Size = new System.Drawing.Size(83, 13);
            this.lblQuestionTimer.TabIndex = 1;
            this.lblQuestionTimer.Text = "Time Remaining";
            // 
            // lblFullQuizTimer
            // 
            this.lblFullQuizTimer.AutoSize = true;
            this.lblFullQuizTimer.Location = new System.Drawing.Point(375, 65);
            this.lblFullQuizTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullQuizTimer.Name = "lblFullQuizTimer";
            this.lblFullQuizTimer.Size = new System.Drawing.Size(107, 13);
            this.lblFullQuizTimer.TabIndex = 2;
            this.lblFullQuizTimer.Text = "Quiz Time Remaining";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 81);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(450, 19);
            this.progressBar.TabIndex = 3;
            // 
            // txtFreeModeAnswer
            // 
            this.txtFreeModeAnswer.Location = new System.Drawing.Point(15, 220);
            this.txtFreeModeAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.txtFreeModeAnswer.Name = "txtFreeModeAnswer";
            this.txtFreeModeAnswer.Size = new System.Drawing.Size(451, 20);
            this.txtFreeModeAnswer.TabIndex = 4;
            this.txtFreeModeAnswer.Visible = false;
            this.txtFreeModeAnswer.TextChanged += new System.EventHandler(this.txtFreeModeAnswer_TextChanged);
            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.Location = new System.Drawing.Point(10, 6);
            this.rbOption1.Margin = new System.Windows.Forms.Padding(2);
            this.rbOption1.MaximumSize = new System.Drawing.Size(450, 0);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(65, 17);
            this.rbOption1.TabIndex = 5;
            this.rbOption1.TabStop = true;
            this.rbOption1.Text = "Option 1";
            this.rbOption1.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.Location = new System.Drawing.Point(10, 27);
            this.rbOption2.Margin = new System.Windows.Forms.Padding(2);
            this.rbOption2.MaximumSize = new System.Drawing.Size(450, 0);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(65, 17);
            this.rbOption2.TabIndex = 6;
            this.rbOption2.TabStop = true;
            this.rbOption2.Text = "Option 2";
            this.rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            this.rbOption3.AutoSize = true;
            this.rbOption3.Location = new System.Drawing.Point(10, 48);
            this.rbOption3.Margin = new System.Windows.Forms.Padding(2);
            this.rbOption3.MaximumSize = new System.Drawing.Size(450, 0);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(65, 17);
            this.rbOption3.TabIndex = 7;
            this.rbOption3.TabStop = true;
            this.rbOption3.Text = "Option 3";
            this.rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption4
            // 
            this.rbOption4.AutoSize = true;
            this.rbOption4.Location = new System.Drawing.Point(10, 72);
            this.rbOption4.Margin = new System.Windows.Forms.Padding(2);
            this.rbOption4.MaximumSize = new System.Drawing.Size(450, 0);
            this.rbOption4.Name = "rbOption4";
            this.rbOption4.Size = new System.Drawing.Size(65, 17);
            this.rbOption4.TabIndex = 8;
            this.rbOption4.TabStop = true;
            this.rbOption4.Text = "Option 4";
            this.rbOption4.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 244);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 24);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(105, 244);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(2);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 24);
            this.btnSkip.TabIndex = 10;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(195, 244);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 24);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRevealAnswer
            // 
            this.btnRevealAnswer.Location = new System.Drawing.Point(285, 244);
            this.btnRevealAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRevealAnswer.Name = "btnRevealAnswer";
            this.btnRevealAnswer.Size = new System.Drawing.Size(100, 24);
            this.btnRevealAnswer.TabIndex = 12;
            this.btnRevealAnswer.Text = "Reveal Answer";
            this.btnRevealAnswer.UseVisualStyleBackColor = true;
            this.btnRevealAnswer.Click += new System.EventHandler(this.btnRevealAnswer_Click);
            // 
            // btnFiftyFifty
            // 
            this.btnFiftyFifty.Location = new System.Drawing.Point(395, 244);
            this.btnFiftyFifty.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiftyFifty.Name = "btnFiftyFifty";
            this.btnFiftyFifty.Size = new System.Drawing.Size(75, 24);
            this.btnFiftyFifty.TabIndex = 13;
            this.btnFiftyFifty.Text = "50/50";
            this.btnFiftyFifty.UseVisualStyleBackColor = true;
            this.btnFiftyFifty.Click += new System.EventHandler(this.btnFiftyFifty_Click);
            // 
            // questionPanel
            // 
            this.questionPanel.AutoScroll = true;
            this.questionPanel.Controls.Add(this.lblQuestionText);
            this.questionPanel.Location = new System.Drawing.Point(15, 16);
            this.questionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(450, 49);
            this.questionPanel.TabIndex = 14;
            // 
            // answerPanel
            // 
            this.answerPanel.AutoScroll = true;
            this.answerPanel.Controls.Add(this.rbOption1);
            this.answerPanel.Controls.Add(this.rbOption2);
            this.answerPanel.Controls.Add(this.rbOption3);
            this.answerPanel.Controls.Add(this.rbOption4);
            this.answerPanel.Location = new System.Drawing.Point(15, 117);
            this.answerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.Size = new System.Drawing.Size(450, 99);
            this.answerPanel.TabIndex = 15;
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.AutoSize = true;
            this.lblQuestionCount.Location = new System.Drawing.Point(15, 102);
            this.lblQuestionCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(85, 13);
            this.lblQuestionCount.TabIndex = 16;
            this.lblQuestionCount.Text = "Question 1 of 10";
            // 
            // QuizInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblQuestionCount);
            this.Controls.Add(this.questionPanel);
            this.Controls.Add(this.answerPanel);
            this.Controls.Add(this.lblQuestionTimer);
            this.Controls.Add(this.lblFullQuizTimer);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtFreeModeAnswer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRevealAnswer);
            this.Controls.Add(this.btnFiftyFifty);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuizInterfaceForm";
            this.Text = "Quiz Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizInterfaceForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizInterfaceForm_Load);
            this.questionPanel.ResumeLayout(false);
            this.questionPanel.PerformLayout();
            this.answerPanel.ResumeLayout(false);
            this.answerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}