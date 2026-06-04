using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        private BankAccount account;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            // 初始化帳戶，暫時設為 null，需透過建立帳戶功能來初始化
            account = null;
            depositGroupBox.Visible = false;
            groupBox1.Visible = false;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            // 檢查帳戶是否已初始化
            if (account == null)
            {
                MessageBox.Show("請先建立帳戶。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amount;
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                account.Deposit(amount);
                balanceLabel.Text = account.AccountNumber + "\n"
                    + account.Name + "\n"
                    + account.Balance.ToString("C");
                depositTextBox.Clear();
            }
            else
            {
                MessageBox.Show("請輸入有效的存款金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {           
            // 檢查帳戶是否已初始化
            if (account == null)
            {
                MessageBox.Show("請先建立帳戶。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amount;
            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                // 只有提款成功時才更新顯示
                if (account.Withdraw(amount))
                {
                    balanceLabel.Text = account.AccountNumber + "\n"
                        + account.Name + "\n"
                        + account.Balance.ToString("C");
                    withdrawTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的提款金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        


        private void exitButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void depositGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            // 檢查帳號欄位是否為空
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("請輸入帳號。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 檢查姓名欄位是否為空
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("請輸入姓名。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 驗證開戶金額欄位
            if (decimal.TryParse(textBox3.Text, out decimal amount))
            {
                string accountNumber = textBox1.Text;
                string name = textBox2.Text;
                
                // 建立新帳戶
                account = new BankAccount(accountNumber, name, amount);
                balanceLabel.Text = accountNumber + "\n"
                    + name + "\n" 
                    + account.Balance.ToString("C");

                // 清空輸入欄位
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                
                // 顯示存款和提款群組
                depositGroupBox.Visible = true;
                groupBox1.Visible = true;
                
                MessageBox.Show("帳戶建立成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("請輸入有效的開戶金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // 此事件當前不使用
        }

        private void balanceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
