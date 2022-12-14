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
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraEditors.Repository;

namespace Grid_Control
{

    public partial class frmGrid : DevExpress.XtraEditors.XtraForm
    {
        BindingList<Record> gridList;
        private RepositoryItemComboBox gradeComboBox;

        // [Grid Dataset 생성 Class]
        public class Record
        {
            public string? COL1 { get; set; }
            public string? COL2 { get; set; }
            public string? COL3 { get; set; }

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

        // [Grid Delete Line Method]
        private void btn_delete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        // [Grid Add Line Method]
        private void btn_add_Click(object sender, EventArgs e)
        {
            Record rec = new Record();
            gridList.Add(rec);
        }

        // [Grid Data Search Method]
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                // 그리드 리스트 초기화
                gridList = new BindingList<Record>();

                // SQL 새연결 정보 생성
                string connectionString = "Server = 127.0.0.1:1433;database=uid=sa;pwd=sa123";
                SqlConnection sqlConn = new SqlConnection(connectionString);
                SqlCommand sqlComm = new SqlCommand();

                sqlComm.Connection = sqlConn;
                sqlComm.CommandText = "select COL1, COL2, COL3 from table where COL1 = '4000'";
                sqlConn.Open();

                // SQL Data Read
                Record rec;

                using (SqlDataReader sqlResponse = sqlComm.ExecuteReader())
                {
                    while (sqlResponse.Read())
                    {
                        rec = new Record();
                        rec.COL1 = sqlResponse["COL1"].ToString();
                        rec.COL2 = sqlResponse["COL2"].ToString();
                        rec.COL3 = sqlResponse["COL3"].ToString();
                        gridList.Add(rec);
                    }
                }

                // SQL 연결 해제 및 그리드 데이터 적용
                sqlConn.Close();
                grdTest.DataSource = gridList;
                gridView1.BestFitColumns();

            }
            catch(Exception ex)
            {
                // Error Message Box Open
                MessageBox.Show(ex.ToString());
            }
        }

        // [Grid Data Excel Export Method]
        private void btn_excelExport_Click(object sender, EventArgs e)
        {
            // Excel용 Grid 너비 Setting
            // - Excel 출력 시 모든 컬럼이 최소 사이즈 Width로 출력되는 상황 해결방법
            gridView1.OptionsPrint.AutoWidth = false;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();                                     // 그리드 컬럼의 최적 사이즈 Setting
            //bestFitBands(grdTest);

            // Excel Export Option Setting
            XlsxExportOptionsEx xlsxOptions = new XlsxExportOptionsEx();
            xlsxOptions.ShowGridLines = true;                               // 그리드 보이는 그대로 Line 출력
            xlsxOptions.SheetName = "화면명_sysdate(20221212092355)";
            xlsxOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG;  // 그리드 형태 그대로 Excel Export

            // Grid Data Excel Export
            string path = "C:\\Users\\pc\\salesGoods.xlsx";
            grdTest.ExportToXlsx(path, xlsxOptions);
        }

        // [Grid Data Band Best Fit Setting]
        private void bestFitBands(AdvBandedGridView _view)
        {
            _view.BeginUpdate();
            _view.OptionsView.ShowColumnHeaders = true;
            foreach (BandedGridColumn col in _view.Columns)
                col.Caption = col.OwnerBand.Caption;
            _view.BestFitColumns();
            _view.OptionsView.ShowColumnHeaders = false;
            _view.EndUpdate();
        }

        // [현재 폼이 보여질 때 Event Method]
        public void frmGrid_Shown(object sender, EventArgs e)
        {
            // 그리드 ComboBox 선언
            this.gradeComboBox = new RepositoryItemComboBox();
            this.gridView1.Columns[1].ColumnEdit = this.gradeComboBox;

            // 그리드 ComboBox 적용
            initializeComboBoxEdit();
        }

        // [Grid 내에 Combo Box Setting Method]
        private void initializeComboBoxEdit()
        {
            // ComboBox에 입력 될 배열
            string[] testArray = new string[] { "0", "1", "2", "3", "4" };

            // ComboBox에 데이터 적용
            DevExpressHelper.ClearComboBoxEdit(gradeComboBox);
            DevExpressHelper.SetComboBoxEditData(gradeComboBox, testArray);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Grade", gradeComboBox.Items[0]);
        }

        private void combo_dropdown_Click(object sender, EventArgs e)
        {
            combo_dropdown.ShowDropDown();
        }

        private void barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Action<bool> dialogYn = null;

            if (e.Item == barButtonItem4)
            {
                
            }
            else if (e.Item == barButtonItem5)
            {
                ShowDialog().Equals(true);
            }
            else if (e.Item == barButtonItem6)
            {
                ShowDialog().Equals(true);
            }
            else
            {
                dialogYn?.Invoke(false);
            }
        }
    }

    // [DevExpress Helper Class]
    public class DevExpressHelper
    {

        /// 콤보 박스 에디터 초기화 Method
        public static void ClearComboBoxEdit(RepositoryItemComboBox comboBoxEdit)
        {
            comboBoxEdit.Items.Clear();
        }

        /// 콤보 박스 에디터 데이터 적용 Method
        public static void SetComboBoxEditData(RepositoryItemComboBox comboBoxEdit, params string[] itemValueArray)
        {
            foreach (string itemValue in itemValueArray)
            {
                comboBoxEdit.Items.Add(itemValue);
            }
        }
    }
}