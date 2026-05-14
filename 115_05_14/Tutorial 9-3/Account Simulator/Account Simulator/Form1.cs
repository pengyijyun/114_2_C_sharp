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
        private BankAccount account = new BankAccount(20000); // 初始化帳戶，初始餘額為20000


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            balanceLabel.Text = account.Balance.ToString("C"); // 顯示初始餘額
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                account.Deposit(amount);
                balanceLabel.Text = account.Balance.ToString("C");
                depositTextBox.Clear();
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {           
           decimal amount;
            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                if (account.Withdraw(amount))
                {
                    balanceLabel.Text = account.Balance.ToString("C");
                    withdrawTextBox.Clear();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
