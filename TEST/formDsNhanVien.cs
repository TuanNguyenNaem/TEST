using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLBH
{
    public partial class formDsNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public formDsNhanVien()
        {
            InitializeComponent();
        }
        private void KhoaDieuKhien()
        {
            textMaNV.Enabled = false;
            cbGioiTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }
        private void formDsNhanVien_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}