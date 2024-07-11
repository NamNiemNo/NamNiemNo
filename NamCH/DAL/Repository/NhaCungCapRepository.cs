using DAL.Context;
using DAL.DomainClass;
using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class NhaCungCapRepository : INhaCungCapRepository
    {
        private List<Nhacungcap> _NhacungCapList;
        private readonly DBContext _dbContext;
        public NhaCungCapRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
            _NhacungCapList = _dbContext.Nhacungcaps.ToList();
        }
        public List<Nhacungcap> GetLstNhaCungCap()
        {
            return _NhacungCapList;
        }
        public List<Nhacungcap> Search(string keyWord)
        {
           return _dbContext.Nhacungcaps.Where(x=>x.Diachi.StartsWith(keyWord)).ToList();
        }
    }
}
