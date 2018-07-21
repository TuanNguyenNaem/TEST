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
using Repository;

namespace QLBH
{
    public partial class formKhachHang : DevExpress.XtraEditors.XtraForm
    {
        QuanLyBanHang_DbContext context;
        CustomerRepository customer;
        private bool create = false;
        public formKhachHang()
        {
            context = new QuanLyBanHang_DbContext();
            customer = new CustomerRepository();
            InitializeComponent();
        }
        private void KhoaDieuKhien()
        {
            textMaKH.Enabled = false;

            txtHoten.Enabled = false;
            cbGioiTinh.Enabled = false;
            dateNgaySinh.Enabled = false;
            txtsdt.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;

            btLuu.Enabled = false;

            btthem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;

            cbGioiTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }
        private void MoDieuKhien()
        {
            textMaKH.Enabled = false;

            txtHoten.Enabled = true;
            cbGioiTinh.Enabled = true;
            dateNgaySinh.Enabled = true;
            txtsdt.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;

            btLuu.Enabled = true;

            btthem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;

            cbGioiTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }
        private void Reset()
        {
            textMaKH.Text = string.Empty;

            txtHoten.Text = string.Empty;
            cbGioiTinh.Text = string.Empty;
            dateNgaySinh.Text = string.Empty;
            txtsdt.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            Reset();
            textMaKH.Text = this.customer.TaoMaKhachHang();
            MoDieuKhien();
            create = true;
        }
        private void formKhachHang_Load_1(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            gridControl1.DataSource = customer.GetAll();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (create)
            {
                //Đang thêm mới
                if (txtHoten.Text == "" || dateNgaySinh.Text == "")
                    XtraMessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                else
                {
                    try
                    {
                        var customer = new KHACHHANG()
                        {
                            MaKH = this.customer.TaoMaKhachHang(),
                            TenKH = txtHoten.Text,
                            GioiTinh = cbGioiTinh.Text,
                            NgaySinh = DateTime.Parse(dateNgaySinh.Text),
                            SDT = txtsdt.Text,
                            DiaChi = txtDiaChi.Text,
                            Email = txtEmail.Text
                        };
                        var result = this.customer.Create(customer);
                        if (result == textMaKH.Text)
                        {
                            XtraMessageBox.Show("Thêm mới thành công!", "Thông báo");
                            gridControl1.DataSource = this.customer.GetAll();
                            Reset();
                            KhoaDieuKhien();
                            create = false;
                        }
                        else
                            XtraMessageBox.Show("Thêm mới thất bại!", "Thông báo");
                    }
                    catch
                    {
                        XtraMessageBox.Show("Vui lòng thử lại!", "Thông báo");
                    }
                }
            }
            else
            {
                //Đang sửa
                //Đang thêm mới
                if (txtHoten.Text == "" || dateNgaySinh.Text == "")
                    XtraMessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                else
                {
                    try
                    {
                        var customer = new KHACHHANG()
                        {
                            MaKH = textMaKH.Text,
                            TenKH = txtHoten.Text,
                            GioiTinh = cbGioiTinh.Text,
                            NgaySinh = DateTime.Parse(dateNgaySinh.Text),
                            SDT = txtsdt.Text,
                            DiaChi = txtDiaChi.Text,
                            Email = txtEmail.Text
                        };
                        var result = this.customer.Update(customer);
                        if (result)
                        {
                            XtraMessageBox.Show("Sửa thông tin khách hàng "+ txtHoten.Text + " thành công!", "Thông báo");
                            gridControl1.DataSource = this.customer.GetAll();
                            Reset();
                            KhoaDieuKhien();
                            create = false;
                        }
                        else
                            XtraMessageBox.Show("Thêm mới thất bại!", "Thông báo");
                    }
                    catch
                    {
                        XtraMessageBox.Show("Vui lòng thử lại!", "Thông báo");
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (textMaKH.Text == "")
                XtraMessageBox.Show("Chưa chọn bản ghi cần sửa!", "Thông báo");
            else
            {
                MoDieuKhien();
                create = false;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (!create)
            {
                int row = gridView1.FocusedRowHandle;
                textMaKH.Text = gridView1.GetRowCellValue(row, gridView1.Columns[0]).ToString();
                txtHoten.Text = gridView1.GetRowCellValue(row, gridView1.Columns[1]).ToString();
                cbGioiTinh.Text = gridView1.GetRowCellValue(row, gridView1.Columns[2]).ToString();
                dateNgaySinh.Text = gridView1.GetRowCellValue(row, gridView1.Columns[3]).ToString();
                txtsdt.Text = gridView1.GetRowCellValue(row, gridView1.Columns[4]).ToString();
                txtDiaChi.Text = gridView1.GetRowCellValue(row, gridView1.Columns[5]).ToString();
                txtEmail.Text = gridView1.GetRowCellValue(row, gridView1.Columns[6]).ToString();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (textMaKH.Text == "")
                XtraMessageBox.Show("Chưa chọn bản ghi cần xóa!", "Thông báo");
            else
            {
                if(XtraMessageBox.Show("Bạn có muốn xóa khách hàng " + txtHoten.Text + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        var result = customer.Delete(textMaKH.Text);
                        if (result)
                        {
                            XtraMessageBox.Show("Xóa thành công!", "Thông báo");
                            gridControl1.DataSource = this.customer.GetAll();
                            Reset();
                            KhoaDieuKhien();
                            create = false;
                        }
                        else
                            XtraMessageBox.Show("Xóa thất bại!", "Thông báo");
                    }
                    catch
                    {
                        XtraMessageBox.Show("Vui lòng thử lại!", "Thông báo");
                    }
                }
            }
        }
    }
}