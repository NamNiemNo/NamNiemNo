using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface ICuaHangRepository 
    {
        List<Cuahang> GetLstCuaHang();
        void GetLstDb();
        bool Add(Cuahang cuahang);
        bool Delete(int id);
        List<Cuahang> Search(string keyWord);
        List<Cuahang> SearchLoaiHang(string keyWord);
        bool Update(Cuahang cuahang);
    }
}
