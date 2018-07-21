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
            return obj.MaKH;
        }
        public bool Update(KHACHHANG obj)
        {

        }
    }
}
