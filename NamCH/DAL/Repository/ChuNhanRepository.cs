using DAL.Context;
using DAL.DomainClass;
using DAL.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ChuNhanRepository : IChuNhanRepository
    {
        private readonly DBContext _dbContext;
        private List<Chunhan> _lstChuNhan;
        public ChuNhanRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
            _lstChuNhan = _dbContext.Chunhans.ToList();
        }
        public List<Chunhan> GetLstChunhan()
        {
           return _lstChuNhan;
        }
    }
}
