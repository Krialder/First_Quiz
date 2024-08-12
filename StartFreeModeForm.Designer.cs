namespace QuizApplication
{
    partial class StartFreeModeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnHell;
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
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnHell = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(50, 50);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(200, 40);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnHell
            // 
            this.btnHell.Location = new System.Drawing.Point(50, 100);
            this.btnHell.Name = "btnHell";
            this.btnHell.Size = new System.Drawing.Size(200, 40);
            this.btnHell.TabIndex = 1;
            this.btnHell.Text = "Hell";
            this.btnHell.UseVisualStyleBackColor = true;
            this.btnHell.Click += new System.EventHandler(this.btnHell_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(50, 150);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 40);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // StartFreeModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnHell);
            this.Controls.Add(this.btnNormal);
            this.Name = "StartFreeModeForm";
            this.Text = "Select Free Mode Difficulty";
            this.ResumeLayout(false);

        }
    }
}
