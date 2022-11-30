using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5행 3열 인벤토리 칸 생성
            // ■■■■■
            // ■■■■■
            // ■■■■■
            Inven newInven = new Inven(5, 3);

            // 아이템 생성(아이템 이름, 아이템 가격)
            Item itemAx = new Item("도끼", 500);
            Item itemSpear = new Item("창", 1000);
            Item itemShield = new Item("방패", 1500);
            Item itemSword = new Item("검", 2000);

            // 인벤토리에 아이템 보관
            newInven.ItemIn(itemAx);
            newInven.ItemIn(itemSpear);
            newInven.ItemIn(itemShield, 10);
            newInven.ItemIn(itemSword, 13);

            while (newInven != null)
            {
                Console.Clear();

                // 인벤토리 생성 랜더링
                newInven.Render();

                // 화살표 버튼 동작 로직
                ConsoleKeyInfo consoleKey = Console.ReadKey();

                switch (consoleKey.Key)
                {
                    case ConsoleKey.LeftArrow:
                        newInven.selectMoveLeft();
                        break;

                    case ConsoleKey.RightArrow:
                        newInven.selectMoveRight();
                        break;

                    case ConsoleKey.UpArrow:
                        newInven.selectMoveUp();
                        break;

                    case ConsoleKey.DownArrow:
                        newInven.selectMoveDown();
                        break;

                    default:
                        break;
                }
            }

        }
    }
}
