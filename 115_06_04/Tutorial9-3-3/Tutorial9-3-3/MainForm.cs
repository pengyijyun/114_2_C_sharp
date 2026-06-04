namespace Tutorial9_3_3
{
    public partial class MainForm : Form
    {
        //儲存銀行帳戶的列表
        public List<BankAccount> accounts = new List<BankAccount>();
        public MainForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
