using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCode
{
    internal class GotoExample
    {
        static void Main(string[] args)
        {
        ineligible:
            Console.WriteLine("you are not eligible for voting");

            int age = 12;
            if (age <= 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("you are eligible for voting");

            }
        }
    }
}
