using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCode
{
    internal class Reference
    {
        static void Main(String[] args)
        {
            int Add ;
            int Substract = 30;
            int Divide = 0;
            int Mutliply = 0;

            Math(90,3,out Add,ref Substract,ref Divide,ref Mutliply);
            Console.WriteLine($"{Add}");
            Console.WriteLine($"{Substract}");
            Console.WriteLine($"{Mutliply}");
            Console.WriteLine($"{Divide}");


        




        }
        static void Math(int a, int b,out int Addition,ref int Multiplication,
            ref int Substraction,ref int Division)
        {
            Addition = a+b;
            Multiplication = a*b;
            Division = a/b;
            Substraction = a-b;
        }
    }
}
