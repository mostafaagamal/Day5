using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Managers
{
    public class CustomersManager : SuperManager<Customers>,ICustomer
    {
        public CustomersManager(DbSet<Customers> set) : base (set)
        {

        }
    }
}
