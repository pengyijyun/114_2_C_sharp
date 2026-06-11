namespace 員工資料管理系統
{
    partial class DeleteForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitle - 刪除員工大標題
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 16F,
                System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(130, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "刪除員工";

            // lblId - 員工編號標籤
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.lblId.Location = new System.Drawing.Point(50, 90);
            this.lblId.Name = "lblId";
            this.lblId.Text = "員工編號：";

            // txtIdNumber - 輸入要刪除的員工編號
            this.txtIdNumber.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.txtIdNumber.Location = new System.Drawing.Point(175, 87);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(200, 27);

            // btnDelete - 刪除按鈕
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnDelete.Location = new System.Drawing.Point(130, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClose - 離開按鈕
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnClose.Location = new System.Drawing.Point(240, 145);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 32);
            this.btnClose.Text = "離開";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // DeleteForm 表單設定
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 210);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtIdNumber);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Name = "DeleteForm";
            this.Text = "刪除員工";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblId;
    }
}