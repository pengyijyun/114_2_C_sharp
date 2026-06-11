namespace 員工資料管理系統
{
    public partial class DeleteForm : Form
    {
        // 存放主表單傳入的員工清單參考
        private List<Employee> employeeList;

        // 建構子：接收主表單的員工清單
        public DeleteForm(List<Employee> list)
        {
            InitializeComponent();
            employeeList = list;
        }

        // 刪除按鈕點擊事件
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 驗證輸入的編號是否為有效整數
            if (!int.TryParse(txtIdNumber.Text, out int idNumber))
            {
                MessageBox.Show("請輸入有效的員工編號。", "輸入錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 在清單中搜尋符合編號的員工
            Employee target = null;
            foreach (Employee emp in employeeList)
            {
                if (emp.IdNumber == idNumber)
                {
                    target = emp;
                    break;
                }
            }

            // 找不到員工
            if (target == null)
            {
                MessageBox.Show($"找不到編號 {idNumber} 的員工。", "查詢結果",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 確認刪除
            DialogResult result = MessageBox.Show(
                $"確定要刪除員工「{target.Name}」（編號：{target.IdNumber}）嗎？",
                "確認刪除",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                employeeList.Remove(target);
                MessageBox.Show($"已成功刪除員工「{target.Name}」。", "刪除成功",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // 離開按鈕點擊事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}