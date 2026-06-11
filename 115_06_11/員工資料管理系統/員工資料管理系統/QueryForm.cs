namespace 員工資料管理系統
{
    public partial class QueryForm : Form
    {
        // 存放主表單傳入的員工清單參考
        private List<Employee> employeeList;

        // 存放查詢結果的暫存清單
        private List<Employee> searchResults = new List<Employee>();

        // 建構子：接收主表單的員工清單
        public QueryForm(List<Employee> list)
        {
            InitializeComponent();
            employeeList = list;
        }

        // 查詢按鈕點擊事件：依關鍵字搜尋員工
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            searchResults.Clear();
            listBoxResult.Items.Clear();
            lblDetail.Text = "";

            if (string.IsNullOrWhiteSpace(keyword))
            {
                // 關鍵字為空：顯示所有員工
                searchResults.AddRange(employeeList);
            }
            else
            {
                // 依姓名或員工編號查詢（支援部分比對）
                foreach (Employee emp in employeeList)
                {
                    if (emp.Name.Contains(keyword) ||
                        emp.IdNumber.ToString().Contains(keyword))
                    {
                        searchResults.Add(emp);
                    }
                }
            }

            // 若查無結果則顯示提示訊息
            if (searchResults.Count == 0)
            {
                MessageBox.Show("查無符合條件的員工。", "查詢結果",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 將每筆查詢結果以四行格式顯示在 ListBox 中
            foreach (Employee emp in searchResults)
            {
                listBoxResult.Items.Add($"員工編號：{emp.IdNumber}");
                listBoxResult.Items.Add($"姓名：{emp.Name}");
                listBoxResult.Items.Add($"部門：{emp.Department}");
                listBoxResult.Items.Add($"職位：{emp.Position}");
                listBoxResult.Items.Add(""); // 每筆之間空一行
            }
        }

        // ListBox 選取變更事件（保留但不需動作）
        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // 關閉按鈕點擊事件：關閉查詢視窗
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}