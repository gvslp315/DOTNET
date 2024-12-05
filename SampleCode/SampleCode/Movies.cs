using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    internal abstract class Movies
    {
        public abstract void Action();
        public abstract void Drama();

        public abstract void Horror();

    }

    class Bhahubali : Movies
    {
        public Bhahubali()
        {
        }

        public override void Action()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"{name}is a action film");

        }

        public override void Drama()
        {
            string name=Console.ReadLine();
            Console.WriteLine($"{name} has a some drama and comedy");
        }

        public override void Horror()
        {
            Console.WriteLine("there is no horror scenes in bhahubali");
        }

        public void Action(string sname, int episodes)
        {
            Console.WriteLine($"{sname} the series has {episodes} episodes");
        }
    }
    }
