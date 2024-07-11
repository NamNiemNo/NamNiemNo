using BUS.IService;
using DAL.DomainClass;
using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class TrungTamService : ITrungTamService
    {
        private readonly ITrungTamRepository _repository;
        public TrungTamService(ITrungTamRepository repository)
        {
            _repository = repository;
        }
        public List<Trungtam> GetTrungTam()
        {
            return _repository.GetLstTrungTam();
        }

      
    }
}
