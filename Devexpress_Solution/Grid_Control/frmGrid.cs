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

        // [Grid Dataset 생성 Class]
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
            // 그리드 Caption 적용
            iniCaption();
        }

        // [Grid Caption 지정 Method]
        public void iniCaption()
        {
            DevExpress.XtraGrid.Columns.GridColumn col;

            col = new GridColumn();
            col.FieldName = "COL1";
            col.Caption = "음식 종류";
            gridView1.Columns.Add(col);

            col = new GridColumn();
            col.FieldName = "COL2";
            col.Caption = "음식명";
            gridView1.Columns.Add(col);

            col = new GridColumn();
            col.FieldName = "COL3";
            col.Caption = "금액";
            col.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            gridView1.Columns.Add(col);

            gridView1.Columns["COL1"].VisibleIndex = 0;
            gridView1.Columns["COL1"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["COL1"].Visible = true;

            gridView1.Columns["COL2"].VisibleIndex = 1;
            gridView1.Columns["COL2"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["COL2"].Visible = true;

            gridView1.Columns["COL3"].VisibleIndex = 2;
            gridView1.Columns["COL3"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["COL3"].Visible = true;

            gridList = new BindingList<Record>();
            grdTest.DataSource = gridList;

        }
    }
}