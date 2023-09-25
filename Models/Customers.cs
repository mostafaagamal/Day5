using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Customers : Main
    {
        public string Name { get; set; }
        public string adress { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {adress}";
        }
    }
}
