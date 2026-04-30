namespace CSV_Reader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.averagesListBox = new System.Windows.Forms.ListBox();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // averagesListBox
            // 
            this.averagesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.averagesListBox.FormattingEnabled = true;
            this.averagesListBox.ItemHeight = 40;
            this.averagesListBox.Location = new System.Drawing.Point(56, 29);
            this.averagesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.averagesListBox.Name = "averagesListBox";
            this.averagesListBox.Size = new System.Drawing.Size(702, 284);
            this.averagesListBox.TabIndex = 0;
            this.averagesListBox.SelectedIndexChanged += new System.EventHandler(this.averagesListBox_SelectedIndexChanged);
            // 
            // getScoresButton
            // 
            this.getScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.getScoresButton.Location = new System.Drawing.Point(167, 333);
            this.getScoresButton.Margin = new System.Windows.Forms.Padding(4);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(195, 69);
            this.getScoresButton.TabIndex = 1;
            this.getScoresButton.Text = "讀取成績";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitButton.Location = new System.Drawing.Point(410, 333);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(195, 69);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 415);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averagesListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CSV 讀取器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox averagesListBox;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
    }
}
