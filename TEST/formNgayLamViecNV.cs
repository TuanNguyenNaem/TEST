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
    public partial class formNgayLamViecNV : DevExpress.XtraEditors.XtraForm
    {
        public formNgayLamViecNV()
        {
            InitializeComponent();

        }
        private void KhoaDieuKhien()
        {
            cbThang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        private void formNgayLamViecNV_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}