namespace QuizApplication
{
    partial class AddQuestionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.Label lblWrongAnswer1;
        private System.Windows.Forms.TextBox txtWrongAnswer1;
        private System.Windows.Forms.Label lblWrongAnswer2;
        private System.Windows.Forms.TextBox txtWrongAnswer2;
        private System.Windows.Forms.Label lblWrongAnswer3;
        private System.Windows.Forms.TextBox txtWrongAnswer3;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReturn;

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
            this.txtQuestionText = new System.Windows.Forms.TextBox();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.lblWrongAnswer1 = new System.Windows.Forms.Label();
            this.txtWrongAnswer1 = new System.Windows.Forms.TextBox();
            this.lblWrongAnswer2 = new System.Windows.Forms.Label();
            this.txtWrongAnswer2 = new System.Windows.Forms.TextBox();
            this.lblWrongAnswer3 = new System.Windows.Forms.Label();
            this.txtWrongAnswer3 = new System.Windows.Forms.TextBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Location = new System.Drawing.Point(20, 20);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(99, 17);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Text = "Question Text";
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.Location = new System.Drawing.Point(20, 40);
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.Size = new System.Drawing.Size(400, 22);
            this.txtQuestionText.TabIndex = 1;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(20, 70);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(104, 17);
            this.lblCorrectAnswer.TabIndex = 2;
            this.lblCorrectAnswer.Text = "Correct Answer";
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Location = new System.Drawing.Point(20, 90);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.Size = new System.Drawing.Size(400, 22);
            this.txtCorrectAnswer.TabIndex = 3;
            // 
            // lblWrongAnswer1
            // 
            this.lblWrongAnswer1.AutoSize = true;
            this.lblWrongAnswer1.Location = new System.Drawing.Point(20, 120);
            this.lblWrongAnswer1.Name = "lblWrongAnswer1";
            this.lblWrongAnswer1.Size = new System.Drawing.Size(109, 17);
            this.lblWrongAnswer1.TabIndex = 4;
            this.lblWrongAnswer1.Text = "Wrong Answer 1";
            // 
            // txtWrongAnswer1
            // 
            this.txtWrongAnswer1.Location = new System.Drawing.Point(20, 140);
            this.txtWrongAnswer1.Name = "txtWrongAnswer1";
            this.txtWrongAnswer1.Size = new System.Drawing.Size(400, 22);
            this.txtWrongAnswer1.TabIndex = 5;
            // 
            // lblWrongAnswer2
            // 
            this.lblWrongAnswer2.AutoSize = true;
            this.lblWrongAnswer2.Location = new System.Drawing.Point(20, 170);
            this.lblWrongAnswer2.Name = "lblWrongAnswer2";
            this.lblWrongAnswer2.Size = new System.Drawing.Size(109, 17);
            this.lblWrongAnswer2.TabIndex = 6;
            this.lblWrongAnswer2.Text = "Wrong Answer 2";
            // 
            // txtWrongAnswer2
            // 
            this.txtWrongAnswer2.Location = new System.Drawing.Point(20, 190);
            this.txtWrongAnswer2.Name = "txtWrongAnswer2";
            this.txtWrongAnswer2.Size = new System.Drawing.Size(400, 22);
            this.txtWrongAnswer2.TabIndex = 7;
            // 
            // lblWrongAnswer3
            // 
            this.lblWrongAnswer3.AutoSize = true;
            this.lblWrongAnswer3.Location = new System.Drawing.Point(20, 220);
            this.lblWrongAnswer3.Name = "lblWrongAnswer3";
            this.lblWrongAnswer3.Size = new System.Drawing.Size(109, 17);
            this.lblWrongAnswer3.TabIndex = 8;
            this.lblWrongAnswer3.Text = "Wrong Answer 3";
            // 
            // txtWrongAnswer3
            // 
            this.txtWrongAnswer3.Location = new System.Drawing.Point(20, 240);
            this.txtWrongAnswer3.Name = "txtWrongAnswer3";
            this.txtWrongAnswer3.Size = new System.Drawing.Size(400, 22);
            this.txtWrongAnswer3.TabIndex = 9;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(20, 270);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(42, 17);
            this.lblMode.TabIndex = 10;
            this.lblMode.Text = "Mode";
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Normal",
            "Hell"});
            this.cbMode.Location = new System.Drawing.Point(20, 290);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(400, 24);
            this.cbMode.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(20, 330);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(320, 330);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 40);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbMode);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.txtWrongAnswer3);
            this.Controls.Add(this.lblWrongAnswer3);
            this.Controls.Add(this.txtWrongAnswer2);
            this.Controls.Add(this.lblWrongAnswer2);
            this.Controls.Add(this.txtWrongAnswer1);
            this.Controls.Add(this.lblWrongAnswer1);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.txtQuestionText);
            this.Controls.Add(this.lblQuestionText);
            this.Name = "AddQuestionForm";
            this.Text = "Add a Question";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
