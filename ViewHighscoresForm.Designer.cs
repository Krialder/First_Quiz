namespace QuizApplication
{
    partial class ViewHighscoresForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvNormalHighscores;
        private System.Windows.Forms.DataGridView dgvHellHighscores;
        private System.Windows.Forms.DataGridView dgvFreeModeNormalHighscores;
        private System.Windows.Forms.DataGridView dgvFreeModeHellHighscores;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblNormalHighscores;
        private System.Windows.Forms.Label lblHellHighscores;
        private System.Windows.Forms.Label lblFreeModeNormalHighscores;
        private System.Windows.Forms.Label lblFreeModeHellHighscores;

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
            this.dgvNormalHighscores = new System.Windows.Forms.DataGridView();
            this.dgvHellHighscores = new System.Windows.Forms.DataGridView();
            this.dgvFreeModeNormalHighscores = new System.Windows.Forms.DataGridView();
            this.dgvFreeModeHellHighscores = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblNormalHighscores = new System.Windows.Forms.Label();
            this.lblHellHighscores = new System.Windows.Forms.Label();
            this.lblFreeModeNormalHighscores = new System.Windows.Forms.Label();
            this.lblFreeModeHellHighscores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormalHighscores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHellHighscores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeModeNormalHighscores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeModeHellHighscores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNormalHighscores
            // 
            this.dgvNormalHighscores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNormalHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNormalHighscores.Location = new System.Drawing.Point(3, 23);
            this.dgvNormalHighscores.Name = "dgvNormalHighscores";
            this.dgvNormalHighscores.RowHeadersWidth = 51;
            this.dgvNormalHighscores.RowTemplate.Height = 24;
            this.dgvNormalHighscores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNormalHighscores.Size = new System.Drawing.Size(794, 110);
            this.dgvNormalHighscores.TabIndex = 0;
            // 
            // dgvHellHighscores
            // 
            this.dgvHellHighscores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHellHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHellHighscores.Location = new System.Drawing.Point(3, 159);
            this.dgvHellHighscores.Name = "dgvHellHighscores";
            this.dgvHellHighscores.RowHeadersWidth = 51;
            this.dgvHellHighscores.RowTemplate.Height = 24;
            this.dgvHellHighscores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHellHighscores.Size = new System.Drawing.Size(794, 110);
            this.dgvHellHighscores.TabIndex = 1;
            // 
            // dgvFreeModeNormalHighscores
            // 
            this.dgvFreeModeNormalHighscores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFreeModeNormalHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFreeModeNormalHighscores.Location = new System.Drawing.Point(3, 295);
            this.dgvFreeModeNormalHighscores.Name = "dgvFreeModeNormalHighscores";
            this.dgvFreeModeNormalHighscores.RowHeadersWidth = 51;
            this.dgvFreeModeNormalHighscores.RowTemplate.Height = 24;
            this.dgvFreeModeNormalHighscores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFreeModeNormalHighscores.Size = new System.Drawing.Size(794, 110);
            this.dgvFreeModeNormalHighscores.TabIndex = 2;
            // 
            // dgvFreeModeHellHighscores
            // 
            this.dgvFreeModeHellHighscores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFreeModeHellHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFreeModeHellHighscores.Location = new System.Drawing.Point(3, 431);
            this.dgvFreeModeHellHighscores.Name = "dgvFreeModeHellHighscores";
            this.dgvFreeModeHellHighscores.RowHeadersWidth = 51;
            this.dgvFreeModeHellHighscores.RowTemplate.Height = 24;
            this.dgvFreeModeHellHighscores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFreeModeHellHighscores.Size = new System.Drawing.Size(794, 110);
            this.dgvFreeModeHellHighscores.TabIndex = 3;
            // 
            // btnReturn
            // 
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturn.Location = new System.Drawing.Point(3, 567);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(794, 40);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.lblNormalHighscores, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.dgvNormalHighscores, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblHellHighscores, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.dgvHellHighscores, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lblFreeModeNormalHighscores, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.dgvFreeModeNormalHighscores, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.lblFreeModeHellHighscores, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.dgvFreeModeHellHighscores, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.btnReturn, 0, 8);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 9;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 610);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // lblNormalHighscores
            // 
            this.lblNormalHighscores.AutoSize = true;
            this.lblNormalHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNormalHighscores.Location = new System.Drawing.Point(3, 0);
            this.lblNormalHighscores.Name = "lblNormalHighscores";
            this.lblNormalHighscores.Size = new System.Drawing.Size(794, 20);
            this.lblNormalHighscores.TabIndex = 5;
            this.lblNormalHighscores.Text = "Normal Mode Highscores";
            this.lblNormalHighscores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHellHighscores
            // 
            this.lblHellHighscores.AutoSize = true;
            this.lblHellHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHellHighscores.Location = new System.Drawing.Point(3, 136);
            this.lblHellHighscores.Name = "lblHellHighscores";
            this.lblHellHighscores.Size = new System.Drawing.Size(794, 20);
            this.lblHellHighscores.TabIndex = 6;
            this.lblHellHighscores.Text = "Hell Mode Highscores";
            this.lblHellHighscores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFreeModeNormalHighscores
            // 
            this.lblFreeModeNormalHighscores.AutoSize = true;
            this.lblFreeModeNormalHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFreeModeNormalHighscores.Location = new System.Drawing.Point(3, 272);
            this.lblFreeModeNormalHighscores.Name = "lblFreeModeNormalHighscores";
            this.lblFreeModeNormalHighscores.Size = new System.Drawing.Size(794, 20);
            this.lblFreeModeNormalHighscores.TabIndex = 7;
            this.lblFreeModeNormalHighscores.Text = "Free Mode Normal Highscores";
            this.lblFreeModeNormalHighscores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFreeModeHellHighscores
            // 
            this.lblFreeModeHellHighscores.AutoSize = true;
            this.lblFreeModeHellHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFreeModeHellHighscores.Location = new System.Drawing.Point(3, 408);
            this.lblFreeModeHellHighscores.Name = "lblFreeModeHellHighscores";
            this.lblFreeModeHellHighscores.Size = new System.Drawing.Size(794, 20);
            this.lblFreeModeHellHighscores.TabIndex = 8;
            this.lblFreeModeHellHighscores.Text = "Free Mode Hell Highscores";
            this.lblFreeModeHellHighscores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewHighscoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ViewHighscoresForm";
            this.Text = "Highscores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormalHighscores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHellHighscores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeModeNormalHighscores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeModeHellHighscores)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
