using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone_Test
{
    // CellPhone 類別 - 代表一個手機物件
    class CellPhone
    {
        private string brand;// 用於存放手機品牌的私有欄位
        private string model;// 用於存放手機型號的私有欄位
        private decimal price;// 用於存放手機價格的私有欄位
                              
        public CellPhone()
            {
            brand = "";
            model = "";
            price = 0.0m;
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
