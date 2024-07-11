using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface INhaCungCapRepository
    {
        List<Nhacungcap> GetLstNhaCungCap();
        List<Nhacungcap> Search(string keyWord);
    }
}
