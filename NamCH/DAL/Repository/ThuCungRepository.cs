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
    public class ThuCungRepository : IThuCungRepository
    {
        private readonly DBContext _dbContext;
        private List<Thucung> _lstThuCung;
        public ThuCungRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
            _lstThuCung = new List<Thucung>();
            GetLstDb();
        }
        public bool Add(Thucung thucung)
        {
            _dbContext.Thucungs.Add(thucung);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var Exist = _dbContext.Thucungs.Find(id);
            if (Exist == null) return false;
            _dbContext.Thucungs.Remove(Exist);
            _dbContext.SaveChanges();
            GetLstDb();
            return true;
        }

        public void GetLstDb()
        {
            _lstThuCung = _dbContext.Thucungs.ToList();
        }

        public List<Thucung> GetLstThucung()
        {
            return _lstThuCung;
        }

        public List<Thucung> Search(string keyWord)
        {
            return _dbContext.Thucungs.Where(p => p.Ten.Contains(keyWord)).ToList();
        }

        public List<Thucung> SearchLoaiHang(string keyWord)
        {
            throw new NotImplementedException();
        }

        public bool Update(Thucung thucung)
        {
            var Exist = _dbContext.Thucungs.Find(thucung.Id);
            if (Exist == null) return false;
            Exist.Ten = thucung.Ten;
            Exist.Loai = thucung.Loai;
            Exist.Maulong = thucung.Maulong;
            Exist.Tuoi = thucung.Tuoi;
            Exist.IdCn = thucung.IdCn;
            _dbContext.SaveChanges();
            GetLstDb();
            return true;
        }
    }
}
