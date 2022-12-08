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
using DevExpress.XtraGrid.Views.Grid;

namespace Grid_Control
{
  

    public partial class frmGrid : DevExpress.XtraEditors.XtraForm
    {
        BindingList<Record> gridList;

        public class Record
        {
            public string COL1 { get; set; }
            public string COL2 { get; set; }
            public string COL3 { get; set; }

        }

        public frmGrid()
        {
            InitializeComponent();
        }

        // [Form Load Method]
        private void frmGrid_Load(object sender, EventArgs e)
        {
            // Grid 적용 Data List 생성
            //List<gridData> dataList = getGridDataList();

            // Grid에 Data List 적용
            //this.grdTest.DataSource = dataList;

            // 그리드 Caption 적용
            iniCaption();
        }

        // [Grid Data List 생성 Method]
        private List<gridData> getGridDataList()
        {
            // Grid Dataset List 생성
            List<gridData> list = new List<gridData>();

            // Grid Dataset 데이터셋 Add
            list.Add(new gridData("과일", "바나나", 1000));
            list.Add(new gridData("과자", "꼬북칩", 5000));
            list.Add(new gridData("음료수", "포카리 스웨트", 1650));

            return list;
        }

        public void iniCaption()
        {
            DevExpress.XtraGrid.Columns.GridColumn col;

            col = new GridColumn();
            col.FieldName = "COL1";
            col.Caption = "COL1";
            gridView1.Columns.Add(col);

            gridView1.Columns["COL1"].VisibleIndex = 1;

            gridList = new BindingList<Record>();
            grdTest.DataSource = gridList;

        }
    }


    

    // [Grid Dataset 생성 Class]
    public class gridData
    {
        string data1 { get; set; }
        string data2 { get; set; }
        int data3 { get; set; }

        // Dataset 생성자
        public gridData(string _data1, string _data2, int _data3)
        {
            this.data1 = _data1;
            this.data2 = _data2;
            this.data3 = _data3;
        }
    }
}