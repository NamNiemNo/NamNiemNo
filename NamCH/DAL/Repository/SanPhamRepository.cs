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
    public class SanPhamRepository : ISanPhamRepository
    {
        private List<Sanpham> _lstSanPham;
        private readonly DBContext _dbContext;
        public SanPhamRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
            _lstSanPham = new List<Sanpham>();
            GetLstDb();
        }
        public bool Add(Sanpham sanpham)
        {
            _dbContext.Sanphams.Add(sanpham);
            _dbContext.SaveChanges();
            GetLstDb();
            return true;
        }

        public bool Delete(int id)
        {
            var Exist = _dbContext.Sanphams.Find(id);
            if (Exist == null) return false;
            _dbContext.Sanphams.Remove(Exist);
            _dbContext.SaveChanges();
            GetLstDb();
            return true;
        }

        public List<Sanpham> Search(string KeyWord)
        {
            return _dbContext.Sanphams.Where(x=>x.Ten.StartsWith(KeyWord) || 
            _dbContext.Nhacungcaps.Where(a=>a.Id == x.IdNcc).Select(e=>e.Diachi).Contains(KeyWord)).ToList();
        }

        public void GetLstDb()
        {
            _lstSanPham = _dbContext.Sanphams.ToList();
        }

        public List<Sanpham> GetLstSanPham()
        {
            return _lstSanPham;
        }

        public bool Update(Sanpham sanpham)
        {
            var Exist = _dbContext.Sanphams.Find(sanpham.Id);
            if (Exist == null) return false;
            Exist.Ten = sanpham.Ten;
            Exist.Mota = sanpham.Mota;
            Exist.IdNcc = sanpham.IdNcc;
            Exist.Soluongtonkho = sanpham.Soluongtonkho;
            Exist.Giatien = sanpham.Giatien;
            _dbContext.SaveChanges();
            GetLstDb();
            return true;
        }
    }
}
