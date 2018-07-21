using DevExpress.XtraEditors;
using QLBH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Helpers;

namespace TEST
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
        }
        private Form CheckForm(Type T)
        {
            foreach (var f in this.MdiChildren)
            {
                if (f.GetType() == T)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formDangNhap form = new formDangNhap();
            this.Hide();
            form.Show();
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDsNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcheck = CheckForm(typeof(formDsNhanVien));
            if (formcheck != null)
            {
                formcheck.Activate();
            }
            else
            {
                formDsNhanVien form = new formDsNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnNgayLamViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcheck = CheckForm(typeof(formNgayLamViecNV));
            if (formcheck != null)
            {
                formcheck.Activate();
            }
            else
            {
                formNgayLamViecNV form = new formNgayLamViecNV();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Click OK để in", "Thông báo");
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Đăng nhập để thêm sản phẩm", "Thông báo");
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Đăng nhập để thêm mới hóa đơn", "Thông báo");
        }
        private void LoadInfoUser()
        {
            tabinfo.Text = "Xin chào: " + Sessions.UserName + " (" + Sessions.Role + ")";
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            if (Sessions.UserName == "" || Sessions.UserName == null)
                tabinfo.Text = string.Empty;
            else
                LoadInfoUser();
        }

        private void btnDsKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcheck = CheckForm(typeof(formKhachHang));
            if (formcheck != null)
            {
                formcheck.Activate();
            }
            else
            {
                formKhachHang form = new formKhachHang();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnKHVip_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcheck = CheckForm(typeof(formDsKhachHangVip));
            if (formcheck != null)
            {
                formcheck.Activate();
            }
            else
            {
                formDsKhachHangVip form = new formDsKhachHangVip();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDsNhanVien_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcheck = CheckForm(typeof(formDsNhanVien));
            if (formcheck != null)
            {
                formcheck.Activate();
            }
            else
            {
                formDsNhanVien form = new formDsNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDsHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcheck = CheckForm(typeof(formDsHangHoa));
            if (formcheck != null)
            {
                formcheck.Activate();
            }
            else
            {
                formDsHangHoa form = new formDsHangHoa();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDSHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcheck = CheckForm(typeof(formDsHoaDon));
            if (formcheck != null)
            {
                formcheck.Activate();
            }
            else
            {
                formDsHoaDon form = new formDsHoaDon();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDoanhThuNgay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcheck = CheckForm(typeof(formTKDoanhThuNgay));
            if (formcheck != null)
            {
                formcheck.Activate();
            }
            else
            {
                formTKDoanhThuNgay form = new formTKDoanhThuNgay();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDoanhThuThang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcheck = CheckForm(typeof(formTKDoanhThuThang));
            if (formcheck != null)
            {
                formcheck.Activate();
            }
            else
            {
                formTKDoanhThuThang form = new formTKDoanhThuThang();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn Đăng xuất", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Sessions.UserName = "";
                Sessions.Role = "";
                Sessions.MaNV = "";
                formMain form = new formMain();
                this.Hide();
                form.Show();
            }
        }

        private void btnTKHangTrongKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var formcheck = CheckForm(typeof(formTKHangTrongKho));
            if (formcheck != null)
            {
                formcheck.Activate();
            }
            else
            {
                formTKHangTrongKho form = new formTKHangTrongKho();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
