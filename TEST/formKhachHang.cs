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
    public partial class formKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public formKhachHang()
        {
            InitializeComponent();
        }
        private void KhoaDieuKhien()
        {
            textMaKH.Enabled = false;
            cbGioiTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        private void formKhachHang_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
        }
        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}