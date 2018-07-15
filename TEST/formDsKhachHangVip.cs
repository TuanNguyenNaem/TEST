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
    public partial class formDsKhachHangVip : DevExpress.XtraEditors.XtraForm
    {
        QuanLyBanHang_DbContext context;
        public formDsKhachHangVip()
        {
            context = new QuanLyBanHang_DbContext();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataCustomer()
        {
            //gridControl1.DataSource = context.KHACHHANGs.ToList();
        }

        private void formDsKhachHangVip_Load(object sender, EventArgs e)
        {
            //LoadDataCustomer();
        }

        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }
    }
}