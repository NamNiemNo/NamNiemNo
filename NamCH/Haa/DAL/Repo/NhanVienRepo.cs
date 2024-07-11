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
    public class NhanVienRepo : IRepoNhanVien
    {
        DBContext db = new DBContext();
        public void Add(string name, string diachi, string sdt, DateOnly ngaytuyen, int idCt)
        {
            Nhanvien nv = new Nhanvien()
            {
                Ten = name,
                Diachi = diachi,
                Sodienthoai = sdt,
                Ngaytuyendung = ngaytuyen,
                IdCn = idCt
            };
            db.Nhanviens.Add(nv);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Nhanvien nv = GetNhanviens().FirstOrDefault(x => x.Id == id);
            db.Nhanviens.Remove(nv);
            db.SaveChanges();
        }

        public List<Congty> GetCongtys()
        {
            return db.Congties.ToList();
        }

        public List<Nhanvien> GetNhanviens()
        {
            return db.Nhanviens.ToList();
        }

        public void Update(int id, string name, string diachi, string sdt, DateOnly ngaytuyen, int idCt)
        {
            Nhanvien nv = GetNhanviens().FirstOrDefault(x => x.Id == id);
            nv.Ten = name;
            nv.Diachi = diachi;
            nv.Sodienthoai= sdt;
            nv.Ngaytuyendung = ngaytuyen;
            nv.IdCn = idCt;

            db.Nhanviens.Update(nv);
            db.SaveChanges();
        }
    }
}
