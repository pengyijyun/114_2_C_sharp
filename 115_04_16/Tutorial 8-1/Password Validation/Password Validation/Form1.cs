using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // NumberUpperCase 方法：接受一個字串參數並返回其中大寫字母的數量
        private int NumberUpperCase(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }

        // NumberLowerCase 方法：接受一個字串參數並返回其中小寫字母的數量
        private int NumberLowerCase(string str)
        {
            int count = 0;
            foreach (char item in str)
            {
                if (char.IsLower(item))
                {
                    count++;
                }
            }
            return count;
        }

        // NumberDigits 方法：接受一個字串參數並返回其中數字的數量
        private int NumberDigits(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }

        // 檢查密碼按鈕點擊事件處理程序
        // 驗證密碼是否符合所有規則：長度、大寫字母、小寫字母、數字
        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8; // 最小密碼長度
            string password = passwordTextBox.Text;
            
            // 檢查密碼長度
            if (password.Length < MIN_LENGTH)
            {
                MessageBox.Show("密碼長度至少要8個位元");
                return;
            }
            
            // 計算密碼中各類字元的數量
            int upperCaseCount = NumberUpperCase(password);
            int lowerCaseCount = NumberLowerCase(password);
            int digitCount = NumberDigits(password);
            
            // 檢查是否包含大寫字母
            if (upperCaseCount < 1)
            {
                MessageBox.Show("密碼必須包含至少一個大寫英文字母");
                return;
            }
            
            // 檢查是否包含小寫字母
            if (lowerCaseCount < 1)
            {
                MessageBox.Show("密碼必須包含至少一個小寫英文字母");
                return;
            }
            
            // 檢查是否包含數字
            if (digitCount < 1)
            {
                MessageBox.Show("密碼必須包含至少一個數字");
                return;
            }
            
            // 所有驗證都通過
            MessageBox.Show("密碼有效");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
