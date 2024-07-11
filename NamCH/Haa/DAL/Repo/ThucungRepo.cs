using DAL.Context;
using DAL.DomainClass;
using DAL.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    
    public class ThucungRepo : IRepothucung
    {
        DBContext _db = new DBContext();
       
        
        public void Add(string ten, string loai, string malong, int tuoi, int idchunhan)
        {
            Thucung tc = new Thucung()
            {
                Ten = ten,
                Loai = loai,
                Maulong = malong,
                Tuoi = tuoi,
                IdCn = idchunhan
            }; 
            _db.Thucungs.Add(tc);
            _db.SaveChanges();
        }

        public List<Chunhan> GetChunhans()
        {
            return _db.Chunhans.ToList();
        }

        public List<Thucung> GetThucungs()
        {
            return _db.Thucungs.ToList();
        }

        

        public void Remove(int id)
        {
            Thucung tc = GetThucungs().FirstOrDefault(x => x.Id == id);
            _db.Thucungs.Remove(tc);
            _db.SaveChanges();
            
        }

       

        public void Update(int id, string ten, string loai, string malong, int tuoi, int idchunhan)
        {

            Thucung tc = GetThucungs().FirstOrDefault(x => x.Id == id);

            tc.Ten = ten;
            tc.Loai = loai;
            tc.Maulong = malong;
            tc.Tuoi = tuoi;
            tc.IdCn = idchunhan;
           
            _db.Thucungs.Update(tc);
            _db.SaveChanges();
        }
    }
}
