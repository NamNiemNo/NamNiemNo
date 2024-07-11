using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface ICuaHangService
    {
        List<Cuahang> GetLstCuaHang();
        bool Add(Cuahang Cuahang);
        bool Remove(int Id);
        bool Update(Cuahang Cuahang);
        List<Cuahang> Search(string keyWord);
        List<Cuahang> SearchLoaiHang(string keyWord);
    }
}
