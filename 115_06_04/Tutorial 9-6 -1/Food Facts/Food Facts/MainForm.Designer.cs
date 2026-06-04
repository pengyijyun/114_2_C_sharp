namespace Food_Facts
{
    partial class MainForm
    {
        /// <summary>
        /// 設計器變數，用於儲存表單元件
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理資源的方法
        /// </summary>
        /// <param name="disposing">若為真表示釋放 managed 資源；否則僅釋放 unmanaged 資源</param>
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
        /// 設計器支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.muffinRadioButton = new System.Windows.Forms.RadioButton();
            this.popcornRadioButton = new System.Windows.Forms.RadioButton();
            this.bananaRadioButton = new System.Windows.Forms.RadioButton();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1 - 食物選擇群組
            // 
            this.groupBox1.Controls.Add(this.muffinRadioButton);
            this.groupBox1.Controls.Add(this.popcornRadioButton);
            this.groupBox1.Controls.Add(this.bananaRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 18F);
            this.groupBox1.Location = new System.Drawing.Point(21, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(570, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇食物";
            // 
            // muffinRadioButton - 馬芬食物選項
            // 
            this.muffinRadioButton.AutoSize = true;
            this.muffinRadioButton.Font = new System.Drawing.Font("新細明體", 18F);
            this.muffinRadioButton.Location = new System.Drawing.Point(49, 171);
            this.muffinRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.muffinRadioButton.Name = "muffinRadioButton";
            this.muffinRadioButton.Size = new System.Drawing.Size(278, 44);
            this.muffinRadioButton.TabIndex = 2;
            this.muffinRadioButton.TabStop = true;
            this.muffinRadioButton.Text = "1個大藍莓馬芬";
            this.muffinRadioButton.UseVisualStyleBackColor = true;
            // 
            // popcornRadioButton - 爆米花食物選項
            // 
            this.popcornRadioButton.AutoSize = true;
            this.popcornRadioButton.Font = new System.Drawing.Font("新細明體", 18F);
            this.popcornRadioButton.Location = new System.Drawing.Point(49, 109);
            this.popcornRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.popcornRadioButton.Name = "popcornRadioButton";
            this.popcornRadioButton.Size = new System.Drawing.Size(278, 44);
            this.popcornRadioButton.TabIndex = 1;
            this.popcornRadioButton.TabStop = true;
            this.popcornRadioButton.Text = "1杯空氣爆米花";
            this.popcornRadioButton.UseVisualStyleBackColor = true;
            // 
            // bananaRadioButton - 香蕉食物選項
            // 
            this.bananaRadioButton.AutoSize = true;
            this.bananaRadioButton.Font = new System.Drawing.Font("新細明體", 18F);
            this.bananaRadioButton.Location = new System.Drawing.Point(49, 47);
            this.bananaRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bananaRadioButton.Name = "bananaRadioButton";
            this.bananaRadioButton.Size = new System.Drawing.Size(170, 44);
            this.bananaRadioButton.TabIndex = 0;
            this.bananaRadioButton.TabStop = true;
            this.bananaRadioButton.Text = "1根香蕉";
            this.bananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // displayButton - 顯示食物資訊按鈕
            // 
            this.displayButton.Font = new System.Drawing.Font("新細明體", 18F);
            this.displayButton.Location = new System.Drawing.Point(21, 263);
            this.displayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(270, 97);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "顯示食物資訊";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton - 結束按鈕
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 18F);
            this.exitButton.Location = new System.Drawing.Point(321, 263);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(270, 97);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm - 主應用程式視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 376);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "食物資訊";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton muffinRadioButton;
        private System.Windows.Forms.RadioButton popcornRadioButton;
        private System.Windows.Forms.RadioButton bananaRadioButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
    }
}
