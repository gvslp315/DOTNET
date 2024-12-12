using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    internal class Program
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
        static void Main(string[] args)
        {
            // string nation = Console.ReadLine();

            // int age = Convert.ToInt32(Console.ReadLine());
            // string name= Console.ReadLine();
            // if (age > 18 && nation=="indian")
            // {
            //     Console.WriteLine("you are eligible"+ name+"to vote");
            // }
            // else
            // {
            //     Console.WriteLine( $"{name}  not eligible for vote");
            // }
            //Console.WriteLine("hi hello good morning");

            //Sample code


            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 3 || i == 9)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //for(int i = 1; i <= 6; i++)
            //{
            //    if(i==2 || i == 5)
            //    {

            //        Console.Write(i*i+",");
            //        continue;
            //    }
            //    Console.Write(i+",");


            string[,] movies = {{"pushpa","telugu","1400"},{"gamechanger","english","1500"},
                                {"vikram","tamil","1500"} };
            for (int i = 0; i < movies.GetLength(0); i++)
            {
                if (movies[i, 2] == "1500")
                {
                    Console.WriteLine("movie" + i + ": ");
                    for (int j = 0; j < movies.GetLength(1); j++)
                    {
                        Console.WriteLine(movies[i, j] + ": ");
                    }
                }
               
            }

            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
            //Console.ReadKey();


            Bhahubali bahu = new Bhahubali();
            bahu.Action();
            bahu.Action("Got", 150);

            GenericClass<string> gen = new GenericClass<string>("i ma genric class");

            
        }
    }
}
