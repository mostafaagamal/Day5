using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Managers
{
    public class SuperManager<T> where T : Main
    {
        private DbSet<T> set;
        public SuperManager(DbSet<T> set)
        {
            this.set = set;
        }
        public void Add(T item)
        {
            this.set.Add(item);
        }
        public IEnumerable<T> GetAll()
        {
            return set;
        }
        public T GetById(int id)
        {
            foreach (T item in set)
                if (item.Id == id) return item;
            return null;
        }
        public void Remove(T item)
        {
            this.set.Remove(item);
        }
        public void Update(T item)
        {
            this.set.Update(item);
        }
    }
}
