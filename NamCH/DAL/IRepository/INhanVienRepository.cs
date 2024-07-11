using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface INhanVienRepository
    {
        List<Nhanvien> GetLstNhanVien();
        void GetLstDb();
        bool Add(Nhanvien nhanvien);
        bool Delete(int id);
        List<Nhanvien> Search(string keyWord);
        List<Nhanvien> SearchLoaiHang(string keyWord);

        bool Update(Nhanvien nhanvien);
    }
}
