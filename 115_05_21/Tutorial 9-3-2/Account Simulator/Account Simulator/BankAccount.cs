using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    class BankAccount
    {
        // 帳號
        private string accountNumber;

        // 帳戶所有人姓名
        private string name;

        // 帳戶餘額
        private decimal balance;

        // 建構子，初始化帳號、姓名和帳戶餘額
        public BankAccount(string accountNumber, string name, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            balance = initialBalance;
        }

        // 帳號屬性
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // 姓名屬性
        public string Name
        {
            get { return name; }
        }

        // 取得目前帳戶餘額
        public decimal Balance
        {
            get { return balance; }
        }

        // 存款方法，金額必須大於0
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                MessageBox.Show("存款金額必須為正數");
            }
        }

        // 提款方法，金額必須大於0且不超過現有餘額，成功則回傳 true
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                return true;
            }
            else if(amount <=0)
            {
                MessageBox.Show("提款金額必須為正數");
                return false;
            }
            else
            {
                MessageBox.Show("提款金額不能超過現有餘額");
                return false;
            }
        }


    }
}
