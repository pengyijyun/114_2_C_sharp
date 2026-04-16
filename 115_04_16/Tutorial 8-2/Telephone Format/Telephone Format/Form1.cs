using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // IsValidNumber 方法接受一個字串參數，
        // 如果字串包含10個數字則返回 true，
        // 否則返回 false。
        private bool IsValidNumber(string str)
        {
            // 移除所有空白字符
            str = str.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");
            
            // 檢查字串長度是否為10且全為數字
            if (str.Length == 10 && str.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        // TelephoneFormat 方法按引用接受字串參數，
        // 並將其格式化為電話號碼格式 (XX) XXXX-XXXX
        private void TelephoneFormat(ref string str)
        {
            //string part1 = str.Substring(0, 2); // 提取前2位數字

            //string part2 = str.Substring(2, 4); // 提取中間4位數字
            //string part3 = str.Substring(6, 4); // 提取後4位數字
            //str = "(" + part1 + ") " + part2 + "-" + part3; // 組合成格式化的電話號碼
            // 移除所有非數字字符
            str = new string(str.Where(char.IsDigit).ToArray());
            
            str = str.Insert(0, "(") // 在開頭插入左括號
                     .Insert(3, ") ") // 在第3個位置插入右括號和空格
                     .Insert(8, "-"); // 在第8個位置插入連字符

            // 確保字串長度為10
            if (str.Length == 10)
            {
                // 使用子字串方法提取各部分並格式化
                str = "(" + str.Substring(0, 2) + ") " + 
                      str.Substring(2, 4) + "-" + 
                      str.Substring(6, 4);
            }
        }

        // formatButton_Click 事件處理方法
        // 當用戶點擊格式化按鈕時執行
        private void formatButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 從文字框中獲取輸入的電話號碼
                string phoneNumber = numberTextBox.Text;
                
                // 驗證輸入的電話號碼是否有效
                if (IsValidNumber(phoneNumber))
                {
                    // 調用格式化方法格式化電話號碼
                    TelephoneFormat(ref phoneNumber);
                    
                    // 將格式化後的電話號碼顯示在文字框中
                    numberTextBox.Text = phoneNumber;
                    
                    // 清空文字框內容以準備下一次輸入
                    numberTextBox.Clear();
                    
                    // 顯示成功消息
                    MessageBox.Show("格式化成功：" + phoneNumber, "成功");
                }
                else
                {
                    // 顯示錯誤消息提示用戶輸入格式不正確
                    MessageBox.Show("請輸入10位數字", "輸入錯誤");
                    
                    // 清空文字框
                    numberTextBox.Clear();
                    
                    // 將焦點設回文字框
                    numberTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                // 顯示異常消息
                MessageBox.Show("發生錯誤：" + ex.Message, "錯誤");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void instructionLabel_Click(object sender, EventArgs e)
        {

        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
