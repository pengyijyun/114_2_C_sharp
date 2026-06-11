namespace 員工資料管理系統
{
    public partial class Form1 : Form
    {
        // 儲存所有員工資料的清單
        private List<Employee> employeeList = new List<Employee>();

        // 員工資料檔案路徑
        private const string EMPLOYEE_FILE = "employees.txt";

        // 建構子
        public Form1()
        {
            InitializeComponent();
        }

        // 表單載入事件：從檔案讀取員工資料
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployeesFromFile();
            RefreshListBox();
        }

        // 從 employees.txt 讀取員工資料
        private void LoadEmployeesFromFile()
        {
            employeeList.Clear();

            if (!File.Exists(EMPLOYEE_FILE))
                return;

            try
            {
                using (StreamReader reader = new StreamReader(EMPLOYEE_FILE))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        string[] parts = line.Split('|');
                        if (parts.Length == 4 && int.TryParse(parts[0], out int idNumber))
                        {
                            Employee emp = new Employee(parts[1], idNumber, parts[2], parts[3]);
                            employeeList.Add(emp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取員工檔案失敗：{ex.Message}", "錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 將員工資料寫回 employees.txt
        private void SaveEmployeesToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(EMPLOYEE_FILE))
                {
                    foreach (Employee emp in employeeList)
                    {
                        writer.WriteLine($"{emp.IdNumber}|{emp.Name}|{emp.Department}|{emp.Position}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存員工檔案失敗：{ex.Message}", "錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 重新整理主視窗 ListBox 並儲存到檔案
        private void RefreshListBox()
        {
            employeeListBox.Items.Clear();
            foreach (Employee emp in employeeList)
            {
                employeeListBox.Items.Add($"{emp.IdNumber}\t{emp.Name}");
            }
            SaveEmployeesToFile();
        }

        // 新增員工按鈕：開啟新增員工視窗
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(employeeList);
            addForm.ShowDialog();
            RefreshListBox();
        }

        // 刪除員工按鈕：開啟刪除員工視窗
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(employeeList);
            deleteForm.ShowDialog();
            RefreshListBox();
        }

        // 修改員工按鈕：開啟修改員工視窗
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(employeeList);
            editForm.ShowDialog();
            RefreshListBox();
        }

        // 查詢員工按鈕：開啟查詢員工視窗
        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm(employeeList);
            queryForm.ShowDialog();
        }

        // 離開按鈕：儲存資料後結束程式
        private void btnExit_Click(object sender, EventArgs e)
        {
            SaveEmployeesToFile();
            Application.Exit();
        }

        // 關閉視窗時自動儲存資料
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveEmployeesToFile();
            base.OnFormClosing(e);
        }
    }
}