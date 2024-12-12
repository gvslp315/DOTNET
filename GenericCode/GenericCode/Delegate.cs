using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCode
{
    internal class Delegate
    {
        delegate string DelegateMerger(string s1, string s2);//declaring delegate  
        public class DelegateExample
        {
            static string MergedString = string.Empty;
            public static string FullName(string fn, string ln)
            {
                MergedString = $"{fn} {ln}";
                return MergedString;
            }
            public static string FullLocation(string state, string place)
            {
                MergedString = $"{place} is a city in {state} state";
                return MergedString;
            }
            public static string getFullString()
            {
                return MergedString;
            }

            static void Main(string[] args)
            {
                DelegateMerger mer1 = new DelegateMerger(FullName);
                DelegateMerger mer2 = new DelegateMerger(FullLocation);
                mer1("i am fine", "how are you");
                Console.WriteLine(getFullString());
                mer2("qwerty", "qwertyu");
                Console.WriteLine(getFullString());


            }

        }

        }
    }
