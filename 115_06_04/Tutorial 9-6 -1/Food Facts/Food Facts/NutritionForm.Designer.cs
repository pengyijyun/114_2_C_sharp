namespace Food_Facts
{
    partial class NutritionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carbLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1 - 食物標籤
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "食物：";
            // 
            // foodLabel - 食物數值顯示區域
            // 
            this.foodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.foodLabel.Location = new System.Drawing.Point(260, 20);
            this.foodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(180, 40);
            this.foodLabel.TabIndex = 1;
            this.foodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foodLabel.Click += new System.EventHandler(this.foodLabel_Click);
            // 
            // caloriesLabel - 卡路里數值顯示區域
            // 
            this.caloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.caloriesLabel.Location = new System.Drawing.Point(260, 70);
            this.caloriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(180, 40);
            this.caloriesLabel.TabIndex = 3;
            this.caloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3 - 卡路里標籤
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(40, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "卡路里：";
            // 
            // fatLabel - 脂肪數值顯示區域
            // 
            this.fatLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fatLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fatLabel.Location = new System.Drawing.Point(260, 120);
            this.fatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(180, 40);
            this.fatLabel.TabIndex = 5;
            this.fatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4 - 脂肪標籤
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(40, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "脂肪(克)：";
            // 
            // carbLabel - 碳水化合物數值顯示區域
            // 
            this.carbLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carbLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.carbLabel.Location = new System.Drawing.Point(260, 170);
            this.carbLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(180, 40);
            this.carbLabel.TabIndex = 7;
            this.carbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5 - 碳水化合物標籤
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(15, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "碳水化合物(克)：";
            // 
            // closeButton - 關閉按鈕
            // 
            this.closeButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.closeButton.Location = new System.Drawing.Point(180, 230);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(140, 50);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "關閉";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // NutritionForm - 營養資訊表單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 330);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.carbLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NutritionForm";
            this.Text = "營養資訊";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label foodLabel;
        public System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label carbLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeButton;
    }
}
