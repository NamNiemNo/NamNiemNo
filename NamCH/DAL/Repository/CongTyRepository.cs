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
    public class CongTyRepository : ICongTyRepository
    {
        private readonly DBContext _dbContext;
        private List<Congty> _lstCongTy;
        public CongTyRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
            _lstCongTy = _dbContext.Congties.ToList();
        }
        public List<Congty> GetLstCongty()
        {
            return _lstCongTy;
        }
    }
}
