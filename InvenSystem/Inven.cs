using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace InvenSystem
{
    internal class Inven
    {
        int selectIndex = 0;    // 선택된 아이템 Index
        Item[] ArrItem;         // 아이템 리스트
        int itemX;              // 아이템 인벤토리 행 변수(랜더링시 개행에 사용)
        int itemY;              // 아이템 인벤토리 열 변수

        // ▶ 인벤토리 칸 생성
        public Inven(int _xValue, int _yValue)
        {
            if (_xValue < 1) _xValue = 1;

            if (_yValue < 1) _yValue = 1;

            // 아이템 인벤토리 행 변수(랜더링시 개행에 사용)
            itemX = _xValue;
            itemY = _yValue;
            // 총 아이템 칸 리스트 생성
            ArrItem = new Item[(_xValue * _yValue)];
        }

        // ▶ 아이템 보관 Method (인벤토리 위치 자동배정)
        public void ItemIn(Item _item)
        {
            int index = 0;  // 아이템 보관시 인벤토리 위치 Index

            // 인벤토리 위치 공간 찾기 Loop
            for(int i=0; i<ArrItem.Length; i++)
            {
                // 인벤토리 빈공간 찾았을 경우 Loop Out
                if (null == ArrItem[i])
                {
                    index = i;
                    break;
                }
            }

            // 인벤토리에 해당 아이템 보관
            ArrItem[index] = _item;
        }

        // ▶ 아이템 보관 Method (인벤토리 위치 직접배정)
        public void ItemIn(Item _item, int _invenLoc)
        {
            // 해당 인벤토리 위치에 아이템이 있다면 Return
            if (null != ArrItem[_invenLoc]) return;

            // 인벤토리에 해당 아이템 보관
            ArrItem[_invenLoc] = _item;
        }

        // ▶ 인벤토리 랜더링 Method
        public void Render()
        {
            Boolean invenInItemYn = false;  // 선택된 인벤토리 칸 안에 아이템 여부 변수

            for (int i=0;  i<ArrItem.Length; i++)
            {
                // 인벤토리 랜더링 시 개행 로직
                // 1행에 5열까지만 생성
                if (0 != i && 0 == i % itemX)
                {
                    Console.WriteLine("");
                }

                // 아이템 없는 인벤토리 모양
                if (null == ArrItem[i])
                {
                    // 선택된 아이템 인벤토리 모양
                    if (selectIndex == i)
                    {
                        Console.Write("▣");
                    }
                    else
                    {
                        Console.Write("□");
                    }
                }
                // 아이템 보관된 인벤토리 모양
                else
                {
                    // 선택된 아이템 인벤토리 모양
                    if (selectIndex == i)
                    {
                        // 선택된 인벤토리 칸 안에 아이템 여부 = Y
                        invenInItemYn = true;
                        Console.Write("▣");
                    }
                    else
                    {
                        Console.Write("■");
                    }
                }
            }

            // 선택된 아이템 정보 표시
            if (invenInItemYn) selectedItemInfo(ArrItem[selectIndex]);
        }

        // ▶ 선택된 아이템 정보 표시 Method
        private void selectedItemInfo(Item _selectedItem) 
        {
            Console.WriteLine("");
            Console.WriteLine("**************");
            Console.WriteLine("아이템 정보");
            Console.WriteLine("이름 : " + _selectedItem.mName);
            Console.WriteLine("가격 : " + _selectedItem.mGold);
            Console.WriteLine("**************");
        }

        public void selectMoveLeft()
        {
            selectIndex -= 1;

            int moveIndex = selectIndex;
            selectIndexValidation(moveIndex);

        }

        public void selectMoveRight()
        {
            selectIndex += 1;

            int moveIndex = selectIndex;
            selectIndexValidation(moveIndex);
        }

        public void selectMoveUp()
        {
            selectIndex -= itemX;

            int moveIndex = selectIndex;
            selectIndexValidation(moveIndex);
        }

        public void selectMoveDown()
        {
            selectIndex += itemX;

            int moveIndex = selectIndex;
            selectIndexValidation(moveIndex);
        }

        private void selectIndexValidation(int _moveIndex)
        {
            int totalInvenCount = itemX * itemY;     // 총 인벤토리 칸수

            // 인벤토리 정상 선택 범위
            if (_moveIndex > -1 && _moveIndex < totalInvenCount)
            {
            }
            // 인벤토리 칸 Min Index 검증
            else if(_moveIndex <= -1)
            {
                selectIndex = 0;
                Render();
            }
            // 인벤토리 칸 Max Index 검증
            else if (_moveIndex >= totalInvenCount)
            {
                selectIndex = totalInvenCount - 1;
                Render();
            }
            // 그 외 경우 검증
            else
            {
            }
            
        }
    }
}
