namespace WSAM.Comm.Excel
{
    partial class COM01020101
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
            this.Lbl_Pgm_Id_Nm = new DevExpress.XtraEditors.LabelControl();
            this.Tbx_Pgm_Id_Nm = new DevExpress.XtraEditors.TextEdit();
            this.Tbl_Grd = new DevExpress.Utils.Layout.TablePanel();
            this.Grd_Bookmark = new DevExpress.XtraGrid.GridControl();
            this.Gv_Bookmark = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tbl_Sub_Title = new DevExpress.Utils.Layout.TablePanel();
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
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.Gv_Bookmark.GridControl = this.Grd_Bookmark;
            this.Gv_Bookmark.Name = "Gv_Bookmark";
            this.Gv_Bookmark.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "No";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "프로그램ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "프로그램명";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn4.Caption = "순서";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "등록일시";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // Tbl_Sub_Title
            // 
            this.Tbl_Layout.SetColumn(this.Tbl_Sub_Title, 0);
            this.Tbl_Sub_Title.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.Utils.Layout.TablePanel Tbl_Sub_Title;
        private DevExpress.XtraEditors.LabelControl Lbl_Grd_Title;
    }
}