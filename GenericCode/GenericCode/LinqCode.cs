using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCode
{
    internal class LinqCode
    {
        public void Aggregate()
        {
            IEnumerable<int> ints = new List<int> { 3, 4, 2, 3 };
            // Multiplication method utilizing Aggregate()
            // Will return 72 [ (((3*4)*2)*3) ]
            Console.WriteLine("Aggregate Function Example");
            int Aggresult = ints.Aggregate((mul, val) => mul * val);
            Console.WriteLine(Aggresult);
            Console.ReadKey();
        }

        public void AnyAll()
        {
            Console.WriteLine();
            Console.WriteLine("Any Function Example");
            Console.WriteLine("List: 61.2, 48.7, 72.0, 82.4  ");
            Console.WriteLine(" bool Anyresult = marks.Any(val => val < 50);");
            IEnumerable<double> marks = new List<double> { 61.2, 48.7, 72.0, 82.4 };
            bool Anyresult = marks.Any(val => val < 50);
            // Will return true
            Console.WriteLine(Anyresult);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("All Function Example - 1");
            Console.WriteLine("List: 1.2, 0.7, 2.5, 2.4, 3.8, 0.45  ");
            Console.WriteLine(" bool Anyresult2 = marks2.All(val => val < 1);");
            IEnumerable<double> marks2 = new List<double> { 1.2, 0.7, 2.5, 2.4, 3.8, 0.45 };
            bool Anyresult2 = marks2.All(val => val < 1); // Linq Method syntax
            // Will return false
            Console.WriteLine(Anyresult2);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("All Function Example - 2");
            Console.WriteLine("List: .987, 0.7, .25, .234 ");
            Console.WriteLine(" bool Anyresult3 = marks3.All(val => val < 1);");
            IEnumerable<double> marks3 = new List<double> { .987, 0.7, .25, .234 };
            bool Anyresult3 = marks3.All(val => val < 1);
            // Will return true
            Console.WriteLine(Anyresult3);
            Console.ReadKey();
        }

        public void Averge()
        {
            IEnumerable<double> marks = new List<double> { 61.2, 48.7, 72.0, 82.4 };
            Console.WriteLine();
            Console.WriteLine("Average Function Example 1");
            IEnumerable<int> smarks = new List<int> { 61, 48, 72, 82 };
            double AVGResult = marks.Average();
            // Will return Average mark
            Console.WriteLine(AVGResult);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Average Function Example 2");
            var smarks1 = new List<decimal> { 21.0m, 33.2m, 82, 94.5m };
            decimal AVGResult2 = smarks1.Average();
            // Will return Average mark
            Console.WriteLine(AVGResult2);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Average Function Example 3 with Null values.  It ignores null items");
            var sales = new List<int?> { 36, 12, null, 20, 18, null, 14 };
            double? AVGSales = sales.Average();
            // Will return Average mark
            Console.WriteLine(AVGSales);
            Console.ReadKey();

            //If Average method is called on empty collection, it throws the exception.

            var list = new List<int>();      // empty list
            //double result = list.Average();  // throws InvalidOperationException
            //Console.WriteLine(result);
            //Console.ReadKey();

            //If Average method is called on empty collection of nullable type, it returns null.

            var list2 = new List<int?>();      // empty list of nullable ints
            double? result2 = list2.Average();  // result: null
            Console.WriteLine(result2);
            Console.ReadKey();

            //This example counts the average length of the strings.

            var stringList = new List<string> { "Logesh", "Chennai", "Tamilnadu", "India" };

            // these two lines do the same
            double sresult = stringList.Select(x => x.Length).Average();
            Console.WriteLine(sresult);

            double sresult1 = stringList.Average(x => x.Length);
            Console.WriteLine(sresult1);
            Console.ReadKey();

            // LINQ query expression to calculate average value of items which match specified predicate.
            Console.WriteLine("LINQ query expression to calculate average value of items which match specified predicate.");
            var nlist = new List<int> { 11, 8, 4, 17 };
            double nresult = (from x in nlist where x > 10 select x).Average();  // result: 6.0
            Console.WriteLine(nresult);
            Console.ReadKey();
        }

        public void Casting()
        {

            // LINQ cast example
            ArrayList obj = new ArrayList();
            obj.Add("Tamilnadu");
            obj.Add("Andhra");
            obj.Add("Telangana");
            obj.Add("Kerela");
            obj.Add("Karnataka");
            obj.Add("Jharkand");
            obj.Add("West Bengal");
            obj.Add("Delhi");
            obj.Add("Punjab");

            IEnumerable<string> oresult = obj.Cast<string>();

            foreach (var item in oresult)

            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public void Take()
        {

            // Take 
            Console.WriteLine();
            Console.WriteLine("Take Function Example ");
            IEnumerable<string> fruits = new List<string> { "Banana", "Grapes", "Apple", "Pineapple", "Kiwi", "Strawberry" };
            IEnumerable<string> fruitstaken = fruits.Take(2);
            foreach (var fruit in fruitstaken)
                Console.WriteLine(fruit);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Take While Function Example ");
            IList<string> strList = new List<string>() { "Four", "Five", "Six", "Hundred" };
            var newList = strList.TakeWhile(s => s.Length == 4);
            foreach (var str in newList)
                Console.WriteLine(str);

            IList<string> pincodes = new List<string> { "600783", "631502", "600785", "628501", "25412", "502575" };
            var validpincodes = pincodes.TakeWhile(p => p.Length == 6);
            foreach (var pin in validpincodes)
                Console.WriteLine(pin);

            Console.ReadKey();
        }
    }
}
