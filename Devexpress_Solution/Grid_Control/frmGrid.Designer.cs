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
            this.grdTest.Size = new System.Drawing.Size(624, 533);
            this.grdTest.TabIndex = 0;
            this.grdTest.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdTest;
            this.gridView1.Name = "gridView1";
            // 
            // frmGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 533);
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
    }
}