namespace 員工資料管理系統
{
    partial class QueryForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.lblDetail = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitle - 查詢員工大標題
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 16F,
                System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(130, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "查詢員工";

            // lblKeyword - 員工編號標籤
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.lblKeyword.Location = new System.Drawing.Point(50, 90);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Text = "員工編號：";

            // txtSearch - 輸入員工編號或姓名
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.txtSearch.Location = new System.Drawing.Point(175, 87);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 27);

            // btnSearch - 查詢按鈕
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnSearch.Location = new System.Drawing.Point(145, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnClose - 離開按鈕
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnClose.Location = new System.Drawing.Point(255, 135);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 32);
            this.btnClose.Text = "離開";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // listBoxResult - 查詢結果白色大框（點選後 lblDetail 顯示詳細）
            this.listBoxResult.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.listBoxResult.Location = new System.Drawing.Point(30, 185);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(430, 200);
            this.listBoxResult.SelectedIndexChanged += new System.EventHandler(
                this.listBoxResult_SelectedIndexChanged);

            // lblDetail - 隱藏的詳細資料標籤（不顯示邊框，放在視窗外）
            this.lblDetail.AutoSize = false;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblDetail.Location = new System.Drawing.Point(30, 410);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(430, 0);
            this.lblDetail.Text = "";
            this.lblDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // QueryForm 表單設定
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 410);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.lblDetail);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Name = "QueryForm";
            this.Text = "查詢員工";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblKeyword;
    }
}