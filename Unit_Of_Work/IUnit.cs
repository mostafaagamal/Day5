using ConsoleApp1.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Unit_Of_Work
{
    public interface IUnit
    {
        IBooking BOOK11 { get; }
        ICustomer CUST11 { get; }
        int SaveChanges();
    }
}
