using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepo
{
    internal interface IRepoCuaHang
    {
        List<Cuahang> GetCuahangList();
        List<Trungtam> GetTrungtams();
        void Add(string ten, string mota, string loaihang, DateOnly ngaydky, int idtt);
        void Update(int id, string ten, string mota, string loaihang, DateOnly ngaydky, int idtt);
        void Delete(int id);    
    }
}
