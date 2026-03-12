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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Text = "樂選號碼產生器";
            this.Font = new System.Drawing.Font("Microsoft YaHei", 18F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Title Label
            this.titleLabel = new System.Windows.Forms.Label
            {
                Text = "樂選號碼產生器",
                Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(50, 20),
                Size = new System.Drawing.Size(400, 40),
                AutoSize = false
            };
            this.Controls.Add(this.titleLabel);

            // Number Display Panel with Red Border
            this.numberDisplayPanel = new System.Windows.Forms.Panel
            {
                BackColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(50, 80),
                Size = new System.Drawing.Size(800, 120)
            };
            this.numberDisplayPanel.Paint += NumberDisplayPanel_Paint;
            this.Controls.Add(this.numberDisplayPanel);

            // Create 5 number display labels (label1 - label5)
            this.label1 = new System.Windows.Forms.Label
            {
                Name = "label1",
                Text = "",
                Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(80, 25),
                Size = new System.Drawing.Size(70, 70),
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.Black
            };
            this.numberDisplayPanel.Controls.Add(this.label1);

            this.label2 = new System.Windows.Forms.Label
            {
                Name = "label2",
                Text = "",
                Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(190, 25),
                Size = new System.Drawing.Size(70, 70),
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.Black
            };
            this.numberDisplayPanel.Controls.Add(this.label2);

            this.label3 = new System.Windows.Forms.Label
            {
                Name = "label3",
                Text = "",
                Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(300, 25),
                Size = new System.Drawing.Size(70, 70),
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.Black
            };
            this.numberDisplayPanel.Controls.Add(this.label3);

            this.label4 = new System.Windows.Forms.Label
            {
                Name = "label4",
                Text = "",
                Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(410, 25),
                Size = new System.Drawing.Size(70, 70),
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.Black
            };
            this.numberDisplayPanel.Controls.Add(this.label4);

            this.label5 = new System.Windows.Forms.Label
            {
                Name = "label5",
                Text = "",
                Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(520, 25),
                Size = new System.Drawing.Size(70, 70),
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.Black
            };
            this.numberDisplayPanel.Controls.Add(this.label5);

            // 將 5 個 label 加入 numberLabels 陣列供程式碼使用
            this.numberLabels = new System.Windows.Forms.Label[5];
            this.numberLabels[0] = this.label1;
            this.numberLabels[1] = this.label2;
            this.numberLabels[2] = this.label3;
            this.numberLabels[3] = this.label4;
            this.numberLabels[4] = this.label5;

            // Button Panel
            int buttonY = 220;
            int buttonWidth = 150;
            int buttonHeight = 60;

            // Generate Number Button
            this.generateButton = new System.Windows.Forms.Button
            {
                Text = "產生號碼",
                Font = new System.Drawing.Font("Microsoft YaHei", 16F),
                Location = new System.Drawing.Point(80, buttonY),
                Size = new System.Drawing.Size(buttonWidth, buttonHeight),
                FlatStyle = System.Windows.Forms.FlatStyle.Flat
            };
            this.generateButton.FlatAppearance.BorderSize = 2;
            this.Controls.Add(this.generateButton);

            // Draw Numbers Button
            this.drawButton = new System.Windows.Forms.Button
            {
                Text = "開獎號碼",
                Font = new System.Drawing.Font("Microsoft YaHei", 16F),
                Location = new System.Drawing.Point(375, buttonY),
                Size = new System.Drawing.Size(buttonWidth, buttonHeight),
                FlatStyle = System.Windows.Forms.FlatStyle.Flat
            };
            this.drawButton.FlatAppearance.BorderSize = 2;
            this.Controls.Add(this.drawButton);

            // Exit Button
            this.exitButton = new System.Windows.Forms.Button
            {
                Text = "離開",
                Font = new System.Drawing.Font("Microsoft YaHei", 16F),
                Location = new System.Drawing.Point(670, buttonY),
                Size = new System.Drawing.Size(buttonWidth, buttonHeight),
                FlatStyle = System.Windows.Forms.FlatStyle.Flat
            };
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.Controls.Add(this.exitButton);

            // Generated Numbers Label
            this.generatedNumbersLabel = new System.Windows.Forms.Label
            {
                Text = "顯示自動產生的開獎號碼",
                Font = new System.Drawing.Font("Microsoft YaHei", 14F),
                Location = new System.Drawing.Point(50, 310),
                Size = new System.Drawing.Size(350, 30)
            };
            this.Controls.Add(this.generatedNumbersLabel);

            // Generated Numbers TextBox
            this.generatedNumbersTextBox = new System.Windows.Forms.TextBox
            {
                Font = new System.Drawing.Font("Microsoft YaHei", 14F),
                Location = new System.Drawing.Point(50, 345),
                Size = new System.Drawing.Size(400, 300),
                Multiline = true,
                ScrollBars = System.Windows.Forms.ScrollBars.Vertical,
                ReadOnly = true
            };
            this.Controls.Add(this.generatedNumbersTextBox);

            // Matching Results Label
            this.matchingResultsLabel = new System.Windows.Forms.Label
            {
                Text = "中獎比對結果",
                Font = new System.Drawing.Font("Microsoft YaHei", 14F),
                Location = new System.Drawing.Point(500, 310),
                Size = new System.Drawing.Size(350, 30)
            };
            this.Controls.Add(this.matchingResultsLabel);

            // Matching Results TextBox
            this.matchingResultsTextBox = new System.Windows.Forms.TextBox
            {
                Font = new System.Drawing.Font("Microsoft YaHei", 14F),
                Location = new System.Drawing.Point(500, 345),
                Size = new System.Drawing.Size(350, 300),
                Multiline = true,
                ScrollBars = System.Windows.Forms.ScrollBars.Vertical,
                ReadOnly = true
            };
            this.Controls.Add(this.matchingResultsTextBox);
        }

        private void NumberDisplayPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            using (System.Drawing.Pen redPen = new System.Drawing.Pen(System.Drawing.Color.Red, 3))
            {
                e.Graphics.DrawRectangle(redPen, 2, 2, this.numberDisplayPanel.Width - 5, this.numberDisplayPanel.Height - 5);
            }
        }

        #endregion
    }
}
