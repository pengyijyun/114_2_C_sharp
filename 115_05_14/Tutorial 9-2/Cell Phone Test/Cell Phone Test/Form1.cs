using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        // 主表單的建構函式
        public Form1()
        {
            InitializeComponent();
        }

        // GetPhoneData 方法接受 CellPhone 物件作為參數
        // 將使用者輸入的資料指派給物件的屬性
        private void GetPhoneData(CellPhone phone)
        {
            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;
            if (decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("請輸入有效的價格。");
                phone.Price = 0; // 預設價格為 0
            }
            
        }

        // 建立物件按鈕的點擊事件處理器
        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone(); // 建立 CellPhone 物件
            GetPhoneData(myPhone); // 取得使用者輸入的資料並指派給物件

            // 在輸出標籤中顯示物件的屬性值
            brandLabel.Text = myPhone.Brand; 
            modelLabel.Text = myPhone.Model; 
            priceLabel.Text = myPhone.Price.ToString("C"); 
        }

        // 結束按鈕的點擊事件處理器 - 關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
