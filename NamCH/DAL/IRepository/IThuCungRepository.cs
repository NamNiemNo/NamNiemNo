using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IThuCungRepository
    {
        List<Thucung> GetLstThucung();
        void GetLstDb();
        bool Add(Thucung thucung);
        bool Delete(int id);
        List<Thucung> Search(string keyWord);
        List<Thucung> SearchLoaiHang(string keyWord);

        bool Update(Thucung thucung);
    }
}
