using ConsoleApp1.Managers;
using ConsoleApp1.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Unit_Of_Work
{
    public class Unit : IUnit
    { 
        private IStorage storage;
        public Unit(IStorage storage) {
            this.storage = storage;
        }
        private IBooking BOOK1 { get; set; }

        private ICustomer CUST1 { get; set; }

        public IBooking BOOK11
        {
            get
            {
                if (BOOK1 == null)
                {
                    BOOK1 = new BookingManager(storage.Booking);
                }
                return BOOK1;
            }
        }
        public ICustomer CUST11
        {
            get
            {
                if (CUST1 == null)
                {
                    CUST1 = new CustomersManager(storage.Customer);
                }
                return CUST1;
            }
        }

        public int SaveChanges()
        {
           return storage.SaveChanges();
        }
    }
}
