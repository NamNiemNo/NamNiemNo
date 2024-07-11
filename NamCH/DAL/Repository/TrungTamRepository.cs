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
    public class TrungTamRepository : ITrungTamRepository
    {
        private readonly DBContext _context;
        private List<Trungtam> _lstTrungTam;

        public TrungTamRepository()
        {
        }

        public TrungTamRepository(DBContext context)
        {
            _context = context;
            _lstTrungTam = _context.Trungtams.ToList();
        }
        public List<Trungtam> GetLstTrungTam()
        {
            return _lstTrungTam;
        }
    }
}
