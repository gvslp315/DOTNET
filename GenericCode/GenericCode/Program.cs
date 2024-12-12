using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> gen=new GenericClass<string>("i am generic class");
            GenericClass<int> gen1 = new GenericClass<int>(1234);
            GenericClass<double> gen2 = new GenericClass<double>(1234.12344);

            Collection collect=new Collection();
            collect.Add();

            LinqCode linq = new LinqCode();
            linq.Aggregate();
            linq.AnyAll();

            LinqDistinct ld=new LinqDistinct();
            ld.LinqDistin();

        }
    }
}
