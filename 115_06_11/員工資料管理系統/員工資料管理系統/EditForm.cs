namespace 員工資料管理系統
{
    public partial class EditForm : Form
    {
        // 用來存放主表單傳入的員工清單參考
        private List<Employee> employeeList;
        
        // 用來存放當前正在編輯的員工物件
        private Employee currentEmployee = null;

        // 建構子：接收主表單的員工清單
        public EditForm(List<Employee> list)
        {
            InitializeComponent();
            employeeList = list;
        }

        // 查詢按鈕的點擊事件 - 根據輸入的編號查詢員工
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 驗證輸入的編號是否為有效的整數
            if (!int.TryParse(txtSearchId.Text, out int idNumber))
            {
                MessageBox.Show("請輸入有效的員工編號。", "輸入錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 在清單中搜尋符合編號的員工
            currentEmployee = employeeList.FirstOrDefault(emp => emp.IdNumber == idNumber);

            // 如果找不到該編號的員工
            if (currentEmployee == null)
            {
                MessageBox.Show($"找不到編號 {idNumber} 的員工。", "查詢結果",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                // 清空所有欄位
                ClearFields();
                displayBox.Text = "";
                return;
            }

            // 將查詢到的員工資料填入編輯框
            txtName.Text = currentEmployee.Name;
            txtDepartment.Text = currentEmployee.Department;
            txtPosition.Text = currentEmployee.Position;
            
            // 更新顯示區域
            UpdateDisplayBox();
        }

        // 當任何資料欄位改變時，更新下方的顯示區域
        private void OnDataChanged(object sender, EventArgs e)
        {
            // 只有在已查詢到員工的情況下才更新顯示
            if (currentEmployee != null)
            {
                UpdateDisplayBox();
            }
        }

        // 更新下方顯示區域，實時顯示修改中的員工資料
        private void UpdateDisplayBox()
        {
            if (currentEmployee != null)
            {
                displayBox.Text = 
                    $"員工編號：{currentEmployee.IdNumber}\n" +
                    $"姓　　名：{txtName.Text}\n" +
                    $"部　　門：{txtDepartment.Text}\n" +
                    $"職　　位：{txtPosition.Text}";
            }
        }

        // 清空所有輸入欄位
        private void ClearFields()
        {
            txtName.Text = "";
            txtDepartment.Text = "";
            txtPosition.Text = "";
            currentEmployee = null;
        }

        // 儲存修改按鈕的點擊事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 驗證是否已查詢到員工
            if (currentEmployee == null)
            {
                MessageBox.Show("請先查詢要修改的員工。", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 驗證姓名不可空白
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("姓名不可空白。", "輸入錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 直接修改員工物件的屬性（因為是參考型別，清單中的物件會同步更新）
            currentEmployee.Name = txtName.Text.Trim();
            currentEmployee.Department = txtDepartment.Text.Trim();
            currentEmployee.Position = txtPosition.Text.Trim();

            // 顯示修改成功訊息
            MessageBox.Show("員工資料已更新。", "修改成功",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // 關閉此表單
            this.Close();
        }

        // 取消按鈕的點擊事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 直接關閉視窗，不儲存任何修改
            this.Close();
        }
    }
}
