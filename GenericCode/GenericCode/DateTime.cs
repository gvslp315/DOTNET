using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCode
{
    internal class DateTime
    {
        static void Main(string[] args)
        {
            DateTime dt =new DateTime();
            Console.WriteLine($"{0:d} {dt}");
            Console.WriteLine($"{0:D} {dt}");

        }
    }
}
