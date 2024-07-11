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
    public class CuaHangRepository : ICuaHangRepository
    {
        private readonly DBContext _context;
        private List<Cuahang> _lstCuaHang;
        public CuaHangRepository(DBContext context)
        {
            _context = context;
            _lstCuaHang = new List<Cuahang>();
            GetLstDb();
        }
        public bool Add(Cuahang cuahang)
        {
            _context.Cuahangs.Add(cuahang);
            _context.SaveChanges();
            GetLstDb();
            return true;
        }

        public bool Delete(int id)
        {
            var exist = _context.Cuahangs.FirstOrDefault(x=>x.Id == id);
            if (exist == null)
            {
                return false;
            }
            _context.Cuahangs.Remove(exist); 
            _context.SaveChanges();
            GetLstDb();
            return true;
        }

        public List<Cuahang> Search(string keyWord)
        {
           return _context.Cuahangs.Where(x=>x.Loaihang.Contains(keyWord) || x.Ten.Contains(keyWord)
           || _context.Trungtams.Where(a => a.Id == x.IdCn).Select(x => x.Ten).Contains(keyWord)).ToList();
        }

        public List<Cuahang> GetLstCuaHang()
        {
            return _lstCuaHang;
        }

        public void GetLstDb()
        {
            _lstCuaHang = _context.Cuahangs.ToList();
        }

        public bool Update(Cuahang cuahang)
        {
          
            var Exist = _context.Cuahangs.Find(cuahang.Id);
            if (Exist == null) return false;
            Exist.Ten = cuahang.Ten;
            Exist.Mota = cuahang.Mota;
            Exist.Loaihang = cuahang.Loaihang;
            Exist.Ngaydangky = cuahang.Ngaydangky;
            Exist.IdCn = cuahang.IdCn;
            _context.SaveChanges();
            GetLstDb();
            return true;
        }

        public List<Cuahang> SearchLoaiHang(string keyWord)
        {
            return _context.Cuahangs.Where(x=>x.Loaihang.StartsWith(keyWord)).ToList();
        }
    }
}
