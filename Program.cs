using ConsoleApp1.Managers;
using ConsoleApp1.Models;
using ConsoleApp1.Storage;
using ConsoleApp1.Unit_Of_Work;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main()
        {
            IStorage storage = new Storageee();
            IUnit booooook = new Unit(storage);
            IBooking bokokoko = booooook.BOOK11;
            bokokoko.Add(new Booking() { description = "description", Id = 1, title = "titleeee" });
            ICustomer custcust = booooook.CUST11;
            custcust.Add(new Customers() { adress = "mansiura", Id = 2, Name= "mostafa" });
            custcust.Add(new Customers() { adress = "alexxxxx", Id = 3, Name = "mhamad" });

            booooook.SaveChanges();

            foreach (Customers C in custcust.GetAll())
            {
                Console.WriteLine(C);

            }
        }
    }
}