using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCode
{
    internal class LinqDistinct
    {
        public void LinqDistin()
        {
            Console.WriteLine("Distinct Examples");
            List <int> list = new List<int>() { 1,2,5,6,3,2,1,7,9,3};
            list.Sort();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            //using method syntax
            var distinct=list.Distinct();
            var maxmum=list.Max();
            var minmum=list.Min();
            foreach (int i in distinct)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"Maximum num {maxmum}");
            Console.WriteLine($"Maximum num {minmum}");


            //Query syntax
            var QS=(from num in distinct select num).Distinct();
            foreach (int i in QS)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("distinct number using where ");
            var MS=list.Where(x=>x%2==0).Distinct();
            foreach(int i in MS)
            {
                Console.WriteLine(i);
            }

    
        }
    }
}
