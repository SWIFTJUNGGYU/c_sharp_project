using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenSystem
{
    internal class Item
    {

        public string mName;    // 아이템명
        public int mGold;       // 아이템 가격

        // ▶ 아이템 정보 생성 Method (아이템명, 아이템 가격)
        public Item(string _name, int _gold)
        {
            mName = _name;
            mGold = _gold;
        }

    }
}
