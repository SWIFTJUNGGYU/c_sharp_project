using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Linq;

namespace layout_Control
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {   
            // 해당 Form의 코드를 XML로 Fomatting
            string fileName = string.Format("{0}/{1}.xml", Application.StartupPath, this.Name);

            if (File.Exists(fileName)) layoutControl1.RestoreLayoutFromXml(fileName);

        }

        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            try
            {
                // 코드를 XML화 하여 저장
                layoutControl1.SaveLayoutToXml(string.Format("{0}/{1}.xml", Application.StartupPath, this.Name));
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}