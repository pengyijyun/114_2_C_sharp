using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 主應用程式視窗，用於選擇食物並顯示其營養資訊
namespace Food_Facts
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// MainForm 的建構函式，用於初始化主表單
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「顯示食物資訊」按鈕的點擊事件處理程序，用於顯示選定食物的營養資訊
        /// </summary>
        private void displayButton_Click(object sender, EventArgs e)
        {
            // 建立 NutritionForm 類別的實例
            //NutritionForm nutriForm = new NutritionForm();
            if (bananaRadioButton.Checked)
            {
                selectFood = new Fooditem("1根香蕉", 100, 0.4, 27);
            }
            else if (popcornRadioButton.Checked)
            {
                selectFood = new Fooditem("1杯空氣爆米花", 31, 0.4, 6);
            }
            else if (muffinRadioButton.Checked)
            {
                selectFood = new Fooditem("1個大藍莓馬芬", 385, 9, 67);
            } 

            {
                
            }
            {
                NutritionForm nutriForm = new NutritionForm();

                // 尋找選定的單選按鈕並設定營養資訊
                if (bananaRadioButton.Checked)
                {
                    nutriForm.foodLabel.Text = "1根香蕉";
                    nutriForm.caloriesLabel.Text = "100";
                    nutriForm.fatLabel.Text = "0.4";
                    nutriForm.carbLabel.Text = "27";
                }
                else if (popcornRadioButton.Checked)
                {
                    nutriForm.foodLabel.Text = "1杯空氣爆米花";
                    nutriForm.caloriesLabel.Text = "31";
                    nutriForm.fatLabel.Text = "0.4";
                    nutriForm.carbLabel.Text = "6";
                }
                else if (muffinRadioButton.Checked)
                {
                    nutriForm.foodLabel.Text = "1個大藍莓馬芬";
                    nutriForm.caloriesLabel.Text = "385";
                    nutriForm.fatLabel.Text = "9";
                    nutriForm.carbLabel.Text = "67";
                }

                // 顯示營養資訊視窗
                nutriForm.ShowDialog();
            }

        /// <summary>
        /// 「結束」按鈕的點擊事件處理程序，用於關閉主表單
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單視窗
            this.Close();
        }
    }
}
