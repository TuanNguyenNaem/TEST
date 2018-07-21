using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repository
{
    public class CustomerRepository
    {
        QuanLyBanHang_DbContext context;
        public CustomerRepository()
        {
            context = new QuanLyBanHang_DbContext();
        }
        public string TaoMaKhachHang()
        {
            var idCustomer = GetAll()[GetAll().Count() - 1].MaKH;
            //Định dạng của mã khách hàng: KH000001.
            //Cắt mã khách hàng lấy mình phần sô.
            int number = int.Parse(idCustomer.Substring(2, 6)) + 1; //2
            int temp = 0;
            for (int i = 0; i < idCustomer.Substring(2, 6).Length; i++)
            {
                if (idCustomer.Substring(2, 6)[i] == '0')
                    temp++;
                else
                    break;
            }
            string idNext = number + "";
            for (int i = 0; i < temp; i++)
                idNext = "0" + idNext;
            return "KH" + idNext;
        }
        public List<KHACHHANG> GetAll()
        {
            return context.KHACHHANGs.ToList();
        }
        public KHACHHANG GetById(string id)
        {
            return context.KHACHHANGs.FirstOrDefault(c => c.MaKH == id);
        }
        public bool Delete(string id)
        {
            var customer = GetById(id);
            context.KHACHHANGs.Remove(customer);
            return context.SaveChanges() > 0;
        }
        public string Create(KHACHHANG obj)
        {
            context.KHACHHANGs.Add(obj);
            context.SaveChanges();
            return obj.MaKH;
        }
        public bool Update(KHACHHANG obj)
        {
            var customerTemp = GetById(obj.MaKH);
            customerTemp.TenKH = obj.TenKH;
            customerTemp.GioiTinh = obj.GioiTinh;
            customerTemp.NgaySinh = obj.NgaySinh;
            customerTemp.SDT = obj.SDT;
            customerTemp.DiaChi = obj.DiaChi;
            customerTemp.Email = obj.Email;
            return context.SaveChanges() > 0;
        }
    }
}
