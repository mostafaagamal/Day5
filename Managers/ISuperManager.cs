using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Managers
{
    public interface ISuperManager<T> where T : Main
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T item);
        void Remove(T item);
        void Update(T item);
    }
}
