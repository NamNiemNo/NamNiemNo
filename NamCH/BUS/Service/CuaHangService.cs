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
    public class CuaHangService : ICuaHangService
    {
        private readonly ICuaHangRepository _repository;
        public CuaHangService(ICuaHangRepository repository)
        {
            _repository = repository;
        }
        public bool Add(Cuahang Cuahang)
        {
            return _repository.Add(Cuahang);
        }

        public List<Cuahang> GetLstCuaHang()
        {
           return _repository.GetLstCuaHang();
        }

        public bool Remove(int Id)
        {
            return _repository.Delete(Id);
        }

        public List<Cuahang> Search(string keyWord)
        {
            return _repository.Search(keyWord);
        }

        public List<Cuahang> SearchLoaiHang(string keyWord)
        {
            return _repository.SearchLoaiHang(keyWord);
        }

        public bool Update(Cuahang cuahang)
        {
           return _repository.Update(cuahang);
        }
    }
}
