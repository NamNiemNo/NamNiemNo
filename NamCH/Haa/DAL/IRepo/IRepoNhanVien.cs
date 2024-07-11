using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepo
{
    internal interface IRepoNhanVien
    {
      List<Nhanvien> GetNhanviens();
        List<Congty> GetCongtys();
        void Add (string name, string diachi, string sdt, DateOnly ngaytuyen, int idCt);
        void Update(int id, string name, string diachi, string sdt, DateOnly ngaytuyen, int idCt);
        void Delete(int id);
    }
}
