namespace Multiform_Practice
{
    partial class MainForm
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
            this.displayFormButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayFormButton
            // 
            this.displayFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayFormButton.Location = new System.Drawing.Point(45, 28);
            this.displayFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayFormButton.Name = "displayFormButton";
            this.displayFormButton.Size = new System.Drawing.Size(180, 69);
            this.displayFormButton.TabIndex = 0;
            this.displayFormButton.Text = "顯示表單";
            this.displayFormButton.UseVisualStyleBackColor = true;
            this.displayFormButton.Click += new System.EventHandler(this.displayFormButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(270, 28);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 69);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 110);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayFormButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "多表單練習";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayFormButton;
        private System.Windows.Forms.Button exitButton;
    }
}

