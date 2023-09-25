using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Storage
{
    public interface IStorage
    {
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Customers> Customer { get; set; }
        int SaveChanges();
    }
}
