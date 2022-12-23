
/****************************************************************/
// Program Name    : COM01020101_L
// Program Content : 즐겨찾기 조회 - 트랜잭션 로직
/****************************************************************/
/* 작성자      작성 일자           작성 내용
 * --------------------------------------------------------------
 * 최정규      2022.12.23          최초 개발
/****************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using WSAM.Common;
using WSAM.Model;


namespace WSAM.Logic 
{

    public class COM01020101_L : LogicBase 
    {

        /****************************************************************/
        /* SELECT LOGIC
        /****************************************************************/

        // 즐겨찾기 조회
        public IList<COM01020101Info> getBookmarkList() 
        {
            IList searchlist = DataCaster.getList("com01020101.bookmarkList", null);
            return GridUtil.getIList<COM01020101Info>(searchlist);
        }

        /****************************************************************/
        /* INSERT LOGIC
        /****************************************************************/

        public void save(IList list1, IList list2, IList list3, IList list4) 
        {
            AddCode(list1);                         //grid1 추가
            EditCode(list2);                        //grid1 수정
            AddSubCode(list3);                      //grid2 추가
            EditSubCode(list4);                     //grid2 수정
        }

        /// <summary> CODE 대구분 리스트(grid1) 수정 </summary>    
        private void EditCode(IList list) 
        {
            foreach (BC100Info bc in list) {
                DataCaster.update("bc01.EditCodeList", bc);
            }
            list.Clear();
        }
        
        /// <summary> CODE 대구분 리스트(grid1) 추가 </summary>
        private void AddCode(IList list) 
        {
            foreach (BC100Info bc in list) {
                DataCaster.insert("bc01.AddCodeList", bc);
            }
            list.Clear();
        }
        
        /// <summary> 대구분별 코드 리스트(grid2) 수정 </summary>
        private void EditSubCode(IList list) 
        {
            foreach (BC110Info bc in list) {
                DataCaster.update("bc01.EditSubcodeList", bc);
            }
            list.Clear();
        }
        
        /// <summary> 대구분별 코드 리스트(grid2) 추가 </summary>    
        private void AddSubCode(IList list) 
        {
            foreach (BC110Info bc in list) {
                DataCaster.insert("bc01.AddSubCodeList", bc);
            }
            list.Clear();
        }
    }
}
