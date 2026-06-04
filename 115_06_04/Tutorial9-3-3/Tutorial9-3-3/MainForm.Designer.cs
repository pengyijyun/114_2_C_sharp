namespace Tutorial9_3_3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(128, 85);
            button1.Name = "button1";
            button1.Size = new Size(112, 53);
            button1.TabIndex = 0;
            button1.Text = "開戶";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(329, 81);
            button2.Name = "button2";
            button2.Size = new Size(118, 60);
            button2.TabIndex = 1;
            button2.Text = "存款";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button3.Location = new Point(541, 87);
            button3.Name = "button3";
            button3.Size = new Size(119, 48);
            button3.TabIndex = 2;
            button3.Text = "提款";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button4.Location = new Point(329, 219);
            button4.Name = "button4";
            button4.Size = new Size(110, 58);
            button4.TabIndex = 3;
            button4.Text = "離開";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 326);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 4;
            label1.Text = "已開戶用戶數：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 326);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
    }
}
