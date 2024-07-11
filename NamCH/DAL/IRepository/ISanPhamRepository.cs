using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface ISanPhamRepository
    {
        List<Sanpham> GetLstSanPham();
        void GetLstDb();
        bool Add(Sanpham sanpham);
        bool Delete(int id);
        List<Sanpham> Search(string Id);
        bool Update(Sanpham sanpham);
    }
}
