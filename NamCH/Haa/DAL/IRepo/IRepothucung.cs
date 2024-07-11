using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepo
{
    internal interface IRepothucung
    {
        List<Thucung> GetThucungs();
        List<Chunhan> GetChunhans();
        void Add(string ten, string loai, string malong , int tuoi , int idchunhan);
        void Update(int id, string ten, string loai, string malong, int tuoi, int idchunhan);
        void Remove(int id);
        
    }
}
