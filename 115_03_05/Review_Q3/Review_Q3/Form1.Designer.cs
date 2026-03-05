namespace Review_Q3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UI Components
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel numberDisplayPanel;
        private System.Windows.Forms.Label[] numberLabels;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox generatedNumbersTextBox;
        private System.Windows.Forms.TextBox matchingResultsTextBox;
        private System.Windows.Forms.Label generatedNumbersLabel;
        private System.Windows.Forms.Label matchingResultsLabel;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Panel redBorderPanel)
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Text = "樂選號碼產生器";
            this.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Title Label
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleLabel.Text = "樂選號碼產生器";
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(50, 20);
            this.titleLabel.Size = new System.Drawing.Size(400, 40);
            this.titleLabel.AutoSize = false;
            this.Controls.Add(this.titleLabel);

            // Number Display Panel with Red Border
            this.numberDisplayPanel = new System.Windows.Forms.Panel();
            this.numberDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberDisplayPanel.BackColor = System.Drawing.Color.White;
            this.numberDisplayPanel.Location = new System.Drawing.Point(50, 80);
            this.numberDisplayPanel.Size = new System.Drawing.Size(800, 120);
            this.numberDisplayPanel.Controls.Clear();

            // Create custom panel with red border
            var redBorderPanel = new System.Windows.Forms.Panel();
            redBorderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            redBorderPanel.BackColor = System.Drawing.Color.White;
            redBorderPanel.Location = new System.Drawing.Point(50, 80);
            redBorderPanel.Size = new System.Drawing.Size(800, 120);
            redBorderPanel.Paint += (sender, e) =>
            {
                using (System.Drawing.Pen redPen = new System.Drawing.Pen(System.Drawing.Color.Red, 3))
                {
                    e.Graphics.DrawRectangle(redPen, 2, 2, redBorderPanel.Width - 5, redBorderPanel.Height - 5);
                }
            };
            this.Controls.Add(redBorderPanel);
            this.numberDisplayPanel = redBorderPanel;

            // Create 5 number display labels
            this.numberLabels = new System.Windows.Forms.Label[5];
            int boxWidth = 70;
            int boxHeight = 70;
            int startX = 80;
            int startY = 95;
            int spacing = 110;

            for (int i = 0; i < 5; i++)
            {
                this.numberLabels[i] = new System.Windows.Forms.Label();
                this.numberLabels[i].Text = "";
                this.numberLabels[i].Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
                this.numberLabels[i].Location = new System.Drawing.Point(startX + (i * spacing), startY);
                this.numberLabels[i].Size = new System.Drawing.Size(boxWidth, boxHeight);
                this.numberLabels[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.numberLabels[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.numberLabels[i].BackColor = System.Drawing.Color.White;
                this.numberLabels[i].ForeColor = System.Drawing.Color.Black;
                this.Controls.Add(this.numberLabels[i]);
            }

            // Button Panel
            int buttonY = 220;
            int buttonWidth = 150;
            int buttonHeight = 60;

            // Generate Number Button
            this.generateButton = new System.Windows.Forms.Button();
            this.generateButton.Text = "產生號碼";
            this.generateButton.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.generateButton.Location = new System.Drawing.Point(80, buttonY);
            this.generateButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.FlatAppearance.BorderSize = 2;
            this.Controls.Add(this.generateButton);

            // Draw Numbers Button
            this.drawButton = new System.Windows.Forms.Button();
            this.drawButton.Text = "開獎號碼";
            this.drawButton.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.drawButton.Location = new System.Drawing.Point(375, buttonY);
            this.drawButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.drawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawButton.FlatAppearance.BorderSize = 2;
            this.Controls.Add(this.drawButton);

            // Exit Button
            this.exitButton = new System.Windows.Forms.Button();
            this.exitButton.Text = "離開";
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.exitButton.Location = new System.Drawing.Point(670, buttonY);
            this.exitButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.Controls.Add(this.exitButton);

            // Generated Numbers Label
            this.generatedNumbersLabel = new System.Windows.Forms.Label();
            this.generatedNumbersLabel.Text = "顯示自動產生的開獎號碼";
            this.generatedNumbersLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.generatedNumbersLabel.Location = new System.Drawing.Point(50, 310);
            this.generatedNumbersLabel.Size = new System.Drawing.Size(350, 30);
            this.Controls.Add(this.generatedNumbersLabel);

            // Generated Numbers TextBox
            this.generatedNumbersTextBox = new System.Windows.Forms.TextBox();
            this.generatedNumbersTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.generatedNumbersTextBox.Location = new System.Drawing.Point(50, 345);
            this.generatedNumbersTextBox.Size = new System.Drawing.Size(400, 300);
            this.generatedNumbersTextBox.Multiline = true;
            this.generatedNumbersTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.generatedNumbersTextBox.ReadOnly = true;
            this.Controls.Add(this.generatedNumbersTextBox);

            // Matching Results Label
            this.matchingResultsLabel = new System.Windows.Forms.Label();
            this.matchingResultsLabel.Text = "中獎比對結果";
            this.matchingResultsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.matchingResultsLabel.Location = new System.Drawing.Point(500, 310);
            this.matchingResultsLabel.Size = new System.Drawing.Size(350, 30);
            this.Controls.Add(this.matchingResultsLabel);

            // Matching Results TextBox
            this.matchingResultsTextBox = new System.Windows.Forms.TextBox();
            this.matchingResultsTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.matchingResultsTextBox.Location = new System.Drawing.Point(500, 345);
            this.matchingResultsTextBox.Size = new System.Drawing.Size(350, 300);
            this.matchingResultsTextBox.Multiline = true;
            this.matchingResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.matchingResultsTextBox.ReadOnly = true;
            this.Controls.Add(this.matchingResultsTextBox);
        }

        #endregion
    }
}
