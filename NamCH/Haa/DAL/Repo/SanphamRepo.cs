using DAL.Context;
using DAL.DomainClass;
using DAL.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class SanphamRepo : IRepoSanPham
    {
        DBContext _db =new DBContext();
        public void Add(string ten, string mota, int soluongton, int sotien, int idncc)
        {
            Sanpham sp = new Sanpham()
            {
                Ten = ten,
                Mota = mota,
                Soluongtonkho = soluongton,
                Giatien = sotien,
                IdNcc = idncc

            };
            _db.Sanphams.Add(sp);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
           Sanpham sp = GetSanphams().FirstOrDefault(x => x.Id == id);
            _db.Sanphams.Remove(sp);
            _db.SaveChanges();
        }

        public List<Nhacungcap> GetNhacungcap()
        {
            return _db.Nhacungcaps.ToList();
        }

        public List<Sanpham> GetSanphams()
        {
            return _db.Sanphams.ToList();
        }

        public void Update(int id, string ten, string mota, int soluongton, int sotien, int idncc)
        {
            Sanpham sp = GetSanphams().FirstOrDefault(a => a.Id == id);
            sp.Ten = ten;
            sp.Mota = mota;
            sp.Soluongtonkho = soluongton;
                sp.Giatien = sotien;
            sp.IdNcc= idncc;
            _db.Sanphams.Update(sp);
            _db.SaveChanges ();
        }
    }
}
