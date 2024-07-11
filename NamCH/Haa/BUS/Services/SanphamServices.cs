using DAL.DomainClass;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SanphamServices
    {
        SanphamRepo rp = new SanphamRepo();
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
            rp.Add(ten, mota, soluongton, sotien, idncc);
           
        }

        public void Delete(int id)
        {
            Sanpham sp = GetSanphams().FirstOrDefault(x => x.Id == id);
            rp.Delete(id);
           
        }

        public List<Nhacungcap> GetNhacungcap()
        {
            return rp.GetNhacungcap();
        }

        public List<Sanpham> GetSanphams()
        {
            return rp.GetSanphams();
        }

        public void Update(int id, string ten, string mota, int soluongton, int sotien, int idncc)
        {
            Sanpham sp = GetSanphams().FirstOrDefault(a => a.Id == id);
            sp.Ten = ten;
            sp.Mota = mota;
            sp.Soluongtonkho = soluongton;
            sp.Giatien = sotien;
            sp.IdNcc = idncc;
            rp.Update( id,  ten,  mota,  soluongton,  sotien,  idncc);
        }
    }
}
