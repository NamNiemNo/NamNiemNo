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
    public class CuahangRepo : IRepoCuaHang
    {
        DBContext db = new DBContext();
        public void Add(string ten, string mota, string loaihang, DateOnly ngaydky, int idtt)
        {
            Cuahang ch = new Cuahang()
            {
                Ten = ten,
                Mota = mota,
                Loaihang = loaihang,
                Ngaydangky = ngaydky,
                IdCn = idtt
            };
            db.Cuahangs.Add(ch);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Cuahang ch = GetCuahangList().FirstOrDefault(c => c.Id == id);
            db.Cuahangs.Remove(ch);
            db.SaveChanges();
        }

        public List<Cuahang> GetCuahangList()
        {
           return db.Cuahangs.ToList();
        }

        public List<Trungtam> GetTrungtams()
        {
            return db.Trungtams.ToList();
        }

        public void Update(int id, string ten, string mota, string loaihang, DateOnly ngaydky, int idtt)
        {
            Cuahang ch = GetCuahangList().FirstOrDefault(c => c.Id == id);
            ch.Ten = ten;
            ch.Mota = mota;
            ch.Loaihang = loaihang;
            ch.Ngaydangky = ngaydky;
            ch.IdCn = idtt;
            db.Cuahangs.Update(ch);
            db.SaveChanges();
        }
    }
}
