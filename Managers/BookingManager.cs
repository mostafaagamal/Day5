using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;


namespace ConsoleApp1.Managers
{
    public class BookingManager : SuperManager<Booking>,IBooking
    {
        public BookingManager(DbSet<Booking> set) : base (set)
        {

        } 
    }
}
