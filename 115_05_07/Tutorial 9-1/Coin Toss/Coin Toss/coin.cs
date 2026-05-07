using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    class coin
    {
        private string sideUp; // 儲存正反面

        public coin()
        {
            // 建構子，預設為正面朝上。
            sideUp = "正面";
        }

        public void Toss()
        {
            Random rand = new Random();
            int side = rand.Next(2); // 0 或 1
            if (side == 0)
            {
                sideUp = "正面";
            }
            else
            {
                sideUp = "反面";
            }
        }

        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
