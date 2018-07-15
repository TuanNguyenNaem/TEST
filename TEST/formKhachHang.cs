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
using Models;

namespace QLBH
{
    public partial class formKhachHang : DevExpress.XtraEditors.XtraForm
    {
        QuanLyBanHang_DbContext context;
        public formKhachHang()
        {
            context = new QuanLyBanHang_DbContext();
            InitializeComponent();
        }
        private void KhoaDieuKhien()
        {
            textMaKH.Enabled = false;
            cbGioiTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }
        private void LoadDataCustomer()
        {
            gridControl1.DataSource = context.KHACHHANGs.ToList();
        }

        private void formKhachHang_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            LoadDataCustomer();
        }
        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}