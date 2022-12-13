namespace Grid_Control
{
    partial class frmGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdTest = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_excelExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTest
            // 
            this.grdTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTest.Location = new System.Drawing.Point(0, 0);
            this.grdTest.MainView = this.gridView1;
            this.grdTest.Name = "grdTest";
            this.grdTest.Size = new System.Drawing.Size(901, 548);
            this.grdTest.TabIndex = 0;
            this.grdTest.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdTest;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(487, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "행추가";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(568, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "행삭제";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(649, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "조회";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_excelExport
            // 
            this.btn_excelExport.Location = new System.Drawing.Point(730, 12);
            this.btn_excelExport.Name = "btn_excelExport";
            this.btn_excelExport.Size = new System.Drawing.Size(75, 23);
            this.btn_excelExport.TabIndex = 5;
            this.btn_excelExport.Text = "엑셀 출력";
            this.btn_excelExport.Click += new System.EventHandler(this.btn_excelExport_Click);
            // 
            // frmGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 548);
            this.Controls.Add(this.btn_excelExport);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.grdTest);
            this.Name = "frmGrid";
            this.Text = "frmGrid";
            this.Load += new System.EventHandler(this.frmGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdTest;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.SimpleButton btn_excelExport;
    }
}