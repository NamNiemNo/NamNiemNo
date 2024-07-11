using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepo
{
    internal interface IRepoSanPham
    {
     List<Sanpham> GetSanphams();
        List<Nhacungcap> GetNhacungcap();
        void Add(string ten, string mota, int soluongton, int sotien, int idncc);
        void Update(int id, string ten, string mota, int soluongton, int sotien, int idncc);
        void Delete(int id);
    }
}
