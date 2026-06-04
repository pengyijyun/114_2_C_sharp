using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 食物項目類，用於儲存和管理單一食物的營養資訊
namespace Food_Facts
{
    /// <summary>
    /// Fooditem 類用於表示一個食物項目及其營養資訊
    /// </summary>
    public class Fooditem
    {
        // 儲存食物名稱的欄位
        private string name;
        // 儲存卡路里值的欄位
        private double calories;
        // 儲存脂肪含量的欄位
        private double fat;
        // 儲存碳水化合物含量的欄位
        private double carb;


        /// <summary>
        /// 食物名稱屬性，用於取得和設定食物的名稱
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 卡路里屬性，用於取得和設定食物的卡路里數值
        /// </summary>
        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }
        /// <summary>
        /// 碳水化合物屬性，用於取得和設定食物的碳水化合物含量（克）
        /// </summary>
        public double Carb
        {
            get { return carb; }
            set { carb = value; }
        }
        /// <summary>
        /// 脂肪屬性，用於取得和設定食物的脂肪含量（克）
        /// </summary>
        public double Fat
        {
            get { return fat; }
            set { fat = value; }
        }


    }
}

       


    

