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
    public partial class formDsHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public formDsHangHoa()
        {
            InitializeComponent();
        }
        private void KhoaDieuKhien()
        {
            textMaHH.Enabled = false;
        }
        private void formDsHangHoa_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}