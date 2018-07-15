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
using TEST;
using Models;
using Helpers;

namespace QLBH
{
    public partial class formDangNhap : DevExpress.XtraEditors.XtraForm
    {
        QuanLyBanHang_DbContext context;
        public formDangNhap()
        {
            context = new QuanLyBanHang_DbContext();
            InitializeComponent();
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            formMain form = new formMain();
            this.Hide();
            form.Show();
        }
        

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkShowPass.Checked == true)
            {
                textPass.UseSystemPasswordChar = false;
            }
            else
            {
                textPass.UseSystemPasswordChar = true;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (textTenTK.Text == "" || textPass.Text == "")
                XtraMessageBox.Show("Nhập thiếu thông tin!", "Thông báo");
            else
            {
                var temp = context.TKNHANVIENs.FirstOrDefault(c => c.Account == textTenTK.Text && c.Pass == textPass.Text);
                if(temp == null)
                    XtraMessageBox.Show("Sai thông ti tài khoản hoặc mật khẩu!", "Thông báo");
                else
                {
                    Sessions.MaNV = temp.MaNV;
                    Sessions.UserName = temp.Account;
                    Sessions.Role = temp.Email;
                    formMain form = new formMain();
                    this.Hide();
                    form.Show();
                }
            }
        }
    }
}