using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using System.Data.SqlClient;

namespace WSAM.Comm.Excel
{
    public partial class COM01020101 : DevExpress.XtraEditors.XtraForm
    {
        // 즐겨찾기 조회 데이터 바인딩 리스트 변수
        BindingList<Record> _bookmarkList;

        // [그리드 바인딩 Data Frame 생성]
        public class Record
        {
            public int NO { get; set; }
            public string PGM_ID { get; set; }
            public string PGM_NM { get; set; }
            public int DSP_SEQ { get; set; }
            public string REG_DTM { get; set; }

        }

        public COM01020101()
        {
            InitializeComponent();
        }

        // [Form Load]
        private void COM01020101_Load(object sender, EventArgs e)
        {
            // Data List를 Grid 바인딩
            BindingRecord();
        }

        // [Grid Binding Data List]
        private void BindingRecord()
        {
            _bookmarkList = new BindingList<Record>();
            Grd_Bookmark.DataSource = _bookmarkList;
        }

        // [조회 버튼 클릭 이벤트]
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                // 그리드 데이터 리스트 초기화 
                _bookmarkList = new BindingList<Record>();

                // SQL Connection 정보 생성
                string connString = "Data Source = 127.0.0.1,1433;Initial Catalog=TCHINA;User ID=sa;Password=sa1";
                string sql = "SELECT CD_DIV, CD, CD_DESC, UNUSE, SNO, REG_DT, MOD_DT, REG_ID, MOD_ID FROM TBC110";

                using(SqlConnection sqlConn = new SqlConnection(connString))
                using (SqlCommand sqlComm = new SqlCommand())
                {
                    sqlComm.Connection = sqlConn;
                    sqlComm.CommandText = sql;
                    sqlConn.Open();

                    // SQL Data Read
                    Record rec;

                    // SQL 조회 된 DATA 배치
                    using (SqlDataReader sqlResponse = sqlComm.ExecuteReader())
                    {
                        while (sqlResponse.Read())
                        {
                            rec = new Record();
                            rec.PGM_ID = sqlResponse["CD_DIV"]as string;
                            rec.PGM_NM = sqlResponse["CD"] as string;
                            rec.DSP_SEQ = (int)sqlResponse["SNO"];
                            rec.REG_DTM = sqlResponse["UNUSE"] as string;
                            _bookmarkList.Add(rec);
                        }
                    }

                    // SQL 연결 해제 및 그리드 데이터 적용
                    sqlConn.Close();
                    Grd_Bookmark.DataSource = _bookmarkList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // [Row Number Handling Method]
        private void Gv_Bookmark_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                // Row Index는 0부터 시작하기 때문에 + 1 계산.
                int RowNum = e.RowHandle + 1;
                e.Info.DisplayText = RowNum.ToString();
            }
        }

        // [행삭제 버튼 클릭 이벤트]
        private void Btn_Delete_Row_Click(object sender, EventArgs e)
        {
            Gv_Bookmark.DeleteRow(Gv_Bookmark.FocusedRowHandle);
        }
    }
}