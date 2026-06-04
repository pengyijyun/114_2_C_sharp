using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 營養資訊顯示表單，用於展示選定食物的營養成分詳細資訊
namespace Food_Facts
{
    public partial class NutritionForm : Form
    {
        /// <summary>
        /// 儲存選定的食物物件
        /// </summary>
        private Fooditem foodItem;

        /// <summary>
        /// NutritionForm 的建構函式，用於初始化營養資訊表單
        /// </summary>
        public NutritionForm()
        {
            InitializeComponent();
            this.foodItem = foodItem;
        }

        /// <summary>
        /// 關閉按鈕的點擊事件處理程序，用於關閉營養資訊視窗
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            // 關閉表單視窗
            this.Close();
        }
        private void NutritionForm_Load(object sender, EventArgs e)
        {
            // 在表單載入時顯示食物的營養資訊
            if (foodItem != null)
            {
                foodLabel.Text = foodItem.Name;
                caloriesLabel.Text = foodItem.Calories.ToString();
                fatLabel.Text = foodItem.Fat.ToString();
                carbLabel.Text = foodItem.Carb.ToString();
            }
        }

        /// <summary>
        /// 食物標籤的點擊事件處理程序
        /// </summary>
        private void foodLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
