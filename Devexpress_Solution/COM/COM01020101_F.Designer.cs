namespace WSAM.Comm.Excel
{
    partial class COM01020101_F
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
            this.Tbl_Layout = new DevExpress.Utils.Layout.TablePanel();
            this.Tbl_Search = new DevExpress.Utils.Layout.TablePanel();
            this.Btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.Lbl_Pgm_Id_Nm = new DevExpress.XtraEditors.LabelControl();
            this.Tbx_Pgm_Id_Nm = new DevExpress.XtraEditors.TextEdit();
            this.Tbl_Grd = new DevExpress.Utils.Layout.TablePanel();
            this.Grd_Bookmark = new DevExpress.XtraGrid.GridControl();
            this.Gv_Bookmark = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PGM_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PGM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DSP_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REG_DTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tbl_Sub_Title = new DevExpress.Utils.Layout.TablePanel();
            this.Btn_Delete_Row = new DevExpress.XtraEditors.SimpleButton();
            this.Lbl_Grd_Title = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Layout)).BeginInit();
            this.Tbl_Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Search)).BeginInit();
            this.Tbl_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbx_Pgm_Id_Nm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Grd)).BeginInit();
            this.Tbl_Grd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Bookmark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Bookmark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Sub_Title)).BeginInit();
            this.Tbl_Sub_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbl_Layout
            // 
            this.Tbl_Layout.AutoSize = true;
            this.Tbl_Layout.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 96.31F)});
            this.Tbl_Layout.Controls.Add(this.Tbl_Search);
            this.Tbl_Layout.Controls.Add(this.Tbl_Grd);
            this.Tbl_Layout.Controls.Add(this.Tbl_Sub_Title);
            this.Tbl_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbl_Layout.Location = new System.Drawing.Point(0, 0);
            this.Tbl_Layout.Name = "Tbl_Layout";
            this.Tbl_Layout.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.Tbl_Layout.Size = new System.Drawing.Size(1445, 535);
            this.Tbl_Layout.TabIndex = 0;
            // 
            // Tbl_Search
            // 
            this.Tbl_Layout.SetColumn(this.Tbl_Search, 0);
            this.Tbl_Search.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.Tbl_Search.Controls.Add(this.Btn_Search);
            this.Tbl_Search.Controls.Add(this.Lbl_Pgm_Id_Nm);
            this.Tbl_Search.Controls.Add(this.Tbx_Pgm_Id_Nm);
            this.Tbl_Search.Location = new System.Drawing.Point(3, 3);
            this.Tbl_Search.Name = "Tbl_Search";
            this.Tbl_Layout.SetRow(this.Tbl_Search, 0);
            this.Tbl_Search.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.Tbl_Search.Size = new System.Drawing.Size(1439, 20);
            this.Tbl_Search.TabIndex = 7;
            // 
            // Btn_Search
            // 
            this.Tbl_Search.SetColumn(this.Btn_Search, 2);
            this.Btn_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Search.Location = new System.Drawing.Point(1361, 3);
            this.Btn_Search.Name = "Btn_Search";
            this.Tbl_Search.SetRow(this.Btn_Search, 0);
            this.Btn_Search.Size = new System.Drawing.Size(75, 20);
            this.Btn_Search.TabIndex = 4;
            this.Btn_Search.Text = "조회";
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Lbl_Pgm_Id_Nm
            // 
            this.Tbl_Search.SetColumn(this.Lbl_Pgm_Id_Nm, 0);
            this.Lbl_Pgm_Id_Nm.Location = new System.Drawing.Point(3, 6);
            this.Lbl_Pgm_Id_Nm.Name = "Lbl_Pgm_Id_Nm";
            this.Tbl_Search.SetRow(this.Lbl_Pgm_Id_Nm, 0);
            this.Lbl_Pgm_Id_Nm.Size = new System.Drawing.Size(67, 14);
            this.Lbl_Pgm_Id_Nm.TabIndex = 3;
            this.Lbl_Pgm_Id_Nm.Text = "프로그램ID/명";
            // 
            // Tbx_Pgm_Id_Nm
            // 
            this.Tbl_Search.SetColumn(this.Tbx_Pgm_Id_Nm, 1);
            this.Tbx_Pgm_Id_Nm.Location = new System.Drawing.Point(114, 3);
            this.Tbx_Pgm_Id_Nm.Name = "Tbx_Pgm_Id_Nm";
            this.Tbx_Pgm_Id_Nm.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Tbx_Pgm_Id_Nm.Properties.Appearance.Options.UseBackColor = true;
            this.Tbl_Search.SetRow(this.Tbx_Pgm_Id_Nm, 0);
            this.Tbx_Pgm_Id_Nm.Size = new System.Drawing.Size(215, 20);
            this.Tbx_Pgm_Id_Nm.TabIndex = 2;
            // 
            // Tbl_Grd
            // 
            this.Tbl_Layout.SetColumn(this.Tbl_Grd, 0);
            this.Tbl_Grd.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.Tbl_Grd.Controls.Add(this.Grd_Bookmark);
            this.Tbl_Grd.Location = new System.Drawing.Point(3, 93);
            this.Tbl_Grd.Name = "Tbl_Grd";
            this.Tbl_Layout.SetRow(this.Tbl_Grd, 3);
            this.Tbl_Grd.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.Tbl_Grd.Size = new System.Drawing.Size(1439, 427);
            this.Tbl_Grd.TabIndex = 6;
            // 
            // Grd_Bookmark
            // 
            this.Grd_Bookmark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Bookmark.Location = new System.Drawing.Point(3, 13);
            this.Grd_Bookmark.MainView = this.Gv_Bookmark;
            this.Grd_Bookmark.Name = "Grd_Bookmark";
            this.Grd_Bookmark.Size = new System.Drawing.Size(1433, 411);
            this.Grd_Bookmark.TabIndex = 0;
            this.Grd_Bookmark.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Gv_Bookmark});
            // 
            // Gv_Bookmark
            // 
            this.Gv_Bookmark.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.Gv_Bookmark.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Gv_Bookmark.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Gv_Bookmark.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NO,
            this.PGM_ID,
            this.PGM_NM,
            this.DSP_SEQ,
            this.REG_DTM});
            this.Gv_Bookmark.GridControl = this.Grd_Bookmark;
            this.Gv_Bookmark.Name = "Gv_Bookmark";
            this.Gv_Bookmark.OptionsView.ShowGroupPanel = false;
            this.Gv_Bookmark.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.Gv_Bookmark_CustomDrawRowIndicator);
            // 
            // NO
            // 
            this.NO.AppearanceCell.Options.UseTextOptions = true;
            this.NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NO.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.NO.AppearanceHeader.Options.UseForeColor = true;
            this.NO.Caption = "No";
            this.NO.FieldName = "NO";
            this.NO.Name = "NO";
            this.NO.OptionsColumn.AllowEdit = false;
            this.NO.OptionsColumn.ReadOnly = true;
            this.NO.Visible = true;
            this.NO.VisibleIndex = 0;
            this.NO.Width = 20;
            // 
            // PGM_ID
            // 
            this.PGM_ID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.PGM_ID.AppearanceHeader.Options.UseForeColor = true;
            this.PGM_ID.Caption = "프로그램ID";
            this.PGM_ID.FieldName = "PGM_ID";
            this.PGM_ID.Name = "PGM_ID";
            this.PGM_ID.OptionsColumn.AllowEdit = false;
            this.PGM_ID.OptionsColumn.ReadOnly = true;
            this.PGM_ID.Visible = true;
            this.PGM_ID.VisibleIndex = 1;
            this.PGM_ID.Width = 50;
            // 
            // PGM_NM
            // 
            this.PGM_NM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.PGM_NM.AppearanceHeader.Options.UseForeColor = true;
            this.PGM_NM.Caption = "프로그램명";
            this.PGM_NM.FieldName = "PGM_NM";
            this.PGM_NM.Name = "PGM_NM";
            this.PGM_NM.OptionsColumn.AllowEdit = false;
            this.PGM_NM.OptionsColumn.ReadOnly = true;
            this.PGM_NM.Visible = true;
            this.PGM_NM.VisibleIndex = 2;
            this.PGM_NM.Width = 200;
            // 
            // DSP_SEQ
            // 
            this.DSP_SEQ.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DSP_SEQ.AppearanceCell.Options.UseBackColor = true;
            this.DSP_SEQ.AppearanceCell.Options.UseTextOptions = true;
            this.DSP_SEQ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DSP_SEQ.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.DSP_SEQ.AppearanceHeader.Options.UseForeColor = true;
            this.DSP_SEQ.Caption = "순서";
            this.DSP_SEQ.FieldName = "DSP_SEQ";
            this.DSP_SEQ.Name = "DSP_SEQ";
            this.DSP_SEQ.Visible = true;
            this.DSP_SEQ.VisibleIndex = 3;
            this.DSP_SEQ.Width = 20;
            // 
            // REG_DTM
            // 
            this.REG_DTM.AppearanceCell.Options.UseTextOptions = true;
            this.REG_DTM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.REG_DTM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.REG_DTM.AppearanceHeader.Options.UseForeColor = true;
            this.REG_DTM.Caption = "등록일시";
            this.REG_DTM.FieldName = "REG_DTM";
            this.REG_DTM.Name = "REG_DTM";
            this.REG_DTM.OptionsColumn.AllowEdit = false;
            this.REG_DTM.OptionsColumn.ReadOnly = true;
            this.REG_DTM.Visible = true;
            this.REG_DTM.VisibleIndex = 4;
            this.REG_DTM.Width = 100;
            // 
            // Tbl_Sub_Title
            // 
            this.Tbl_Layout.SetColumn(this.Tbl_Sub_Title, 0);
            this.Tbl_Sub_Title.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.Tbl_Sub_Title.Controls.Add(this.Btn_Delete_Row);
            this.Tbl_Sub_Title.Controls.Add(this.Lbl_Grd_Title);
            this.Tbl_Sub_Title.Location = new System.Drawing.Point(3, 55);
            this.Tbl_Sub_Title.Name = "Tbl_Sub_Title";
            this.Tbl_Layout.SetRow(this.Tbl_Sub_Title, 2);
            this.Tbl_Sub_Title.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.Tbl_Sub_Title.Size = new System.Drawing.Size(1439, 20);
            this.Tbl_Sub_Title.TabIndex = 5;
            // 
            // Btn_Delete_Row
            // 
            this.Tbl_Sub_Title.SetColumn(this.Btn_Delete_Row, 1);
            this.Btn_Delete_Row.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Delete_Row.Location = new System.Drawing.Point(1357, 3);
            this.Btn_Delete_Row.Name = "Btn_Delete_Row";
            this.Tbl_Sub_Title.SetRow(this.Btn_Delete_Row, 0);
            this.Btn_Delete_Row.Size = new System.Drawing.Size(79, 20);
            this.Btn_Delete_Row.TabIndex = 4;
            this.Btn_Delete_Row.Text = "행추가";
            this.Btn_Delete_Row.Click += new System.EventHandler(this.Btn_Delete_Row_Click);
            // 
            // Lbl_Grd_Title
            // 
            this.Tbl_Sub_Title.SetColumn(this.Lbl_Grd_Title, 0);
            this.Lbl_Grd_Title.Location = new System.Drawing.Point(3, 6);
            this.Lbl_Grd_Title.Name = "Lbl_Grd_Title";
            this.Tbl_Sub_Title.SetRow(this.Lbl_Grd_Title, 0);
            this.Lbl_Grd_Title.Size = new System.Drawing.Size(60, 14);
            this.Lbl_Grd_Title.TabIndex = 3;
            this.Lbl_Grd_Title.Text = "즐겨찾기목록";
            // 
            // COM01020101
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 535);
            this.Controls.Add(this.Tbl_Layout);
            this.Name = "COM01020101";
            this.Text = "COM01020101";
            this.Load += new System.EventHandler(this.COM01020101_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Layout)).EndInit();
            this.Tbl_Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Search)).EndInit();
            this.Tbl_Search.ResumeLayout(false);
            this.Tbl_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbx_Pgm_Id_Nm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Grd)).EndInit();
            this.Tbl_Grd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Bookmark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Bookmark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Sub_Title)).EndInit();
            this.Tbl_Sub_Title.ResumeLayout(false);
            this.Tbl_Sub_Title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel Tbl_Layout;
        private DevExpress.Utils.Layout.TablePanel Tbl_Search;
        private DevExpress.XtraEditors.LabelControl Lbl_Pgm_Id_Nm;
        private DevExpress.XtraEditors.TextEdit Tbx_Pgm_Id_Nm;
        private DevExpress.Utils.Layout.TablePanel Tbl_Grd;
        private DevExpress.XtraGrid.GridControl Grd_Bookmark;
        private DevExpress.XtraGrid.Views.Grid.GridView Gv_Bookmark;
        private DevExpress.XtraGrid.Columns.GridColumn NO;
        private DevExpress.XtraGrid.Columns.GridColumn PGM_ID;
        private DevExpress.XtraGrid.Columns.GridColumn PGM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn DSP_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn REG_DTM;
        private DevExpress.Utils.Layout.TablePanel Tbl_Sub_Title;
        private DevExpress.XtraEditors.LabelControl Lbl_Grd_Title;
        private DevExpress.XtraEditors.SimpleButton Btn_Search;
        private DevExpress.XtraEditors.SimpleButton Btn_Delete_Row;
    }
}