using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial9_3_3
{
    public partial class OpenAccountForm : Form
    {
        private List<BankAccount> bankAccounts;

        public OpenAccountForm(List<BankAccount> accounts)
        {
            InitializeComponent();
            bankAccounts = accounts;
        }

        private void OpenAccountForm_Load(object sender, EventArgs e)
        {
            OpenAccountForm openAccountForm = new OpenAccountForm(accounts);
            openAccountForm.ShowDialog();
            //更新已開戶用戶數
            userCountLabel.Text = accounts.Count.ToString();

        }
        private void createAccountButtom_click(object sender, EventArgs e)
        {
            string accountNumber = accountNumberTextBox.Text;
            string name = nameTextBox.Text;
            decimal initialAmount;

            if (decimal.TryParse(initialAmountTextBox.Text, out initialAmount))
            {
                BankAccount newAccount = new BankAccount(accountNumber, name), initialAmount;
            }
    }
        } 
    
