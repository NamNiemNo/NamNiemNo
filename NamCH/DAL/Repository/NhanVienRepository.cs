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
    public class NhanVienRepository : INhanVienRepository
    {
        private readonly DBContext _dbContext;
        private List<Nhanvien> _lstNhanVien;
        public NhanVienRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
            _lstNhanVien = new List<Nhanvien>();
        }
        public bool Add(Nhanvien nhanvien)
        {
            _dbContext.Add(nhanvien);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var Exists = _dbContext.Nhanviens.Find(id);
            if (Exists==null)
                return false;
            _dbContext.Nhanviens.Remove(Exists);
            _dbContext.SaveChanges();
            return true;
        }

        public void GetLstDb()
        {
            _lstNhanVien = _dbContext.Nhanviens.ToList();
        }

        public List<Nhanvien> GetLstNhanVien()
        {
            return _lstNhanVien;
        }

        public List<Nhanvien> Search(string keyWord)
        {
            throw new NotImplementedException();
        }

        public List<Nhanvien> SearchLoaiHang(string keyWord)
        {
            throw new NotImplementedException();
        }

        //public List<Sanpham> Search(string keyWord)
        //{
        //    return;
        //}

        public bool Update(Nhanvien nhanvien)
        {
            var Exists = _dbContext.Nhanviens.Find(nhanvien.Id);
            if (Exists == null) return false;
            Exists.Ten = nhanvien.Ten;
            Exists.Diachi = nhanvien.Diachi;
            Exists.Sodienthoai = nhanvien.Sodienthoai;
            Exists.Ngaytuyendung = nhanvien.Ngaytuyendung;
            Exists.IdCn = nhanvien.IdCn;
            _dbContext.SaveChanges();
            return true;
        }
        //public List<Nhanvien> SearchLoaiHang(string keyWord)
        //{
        //    return _dbContext.Nhanviens.Where(x => x.mota.StartsWith(keyWord)).ToList();
        //}
    }
}
