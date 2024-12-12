using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCode
{
    internal class Collection
    {
        public void Add()
        {
            List<object> list = new List<object>();

            list.Add(123);
            list.Add(143);
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
           // arrayList.Add("asd");
            arrayList.Add(20);
            arrayList.Add(17);
            arrayList.Add(7);
            arrayList.Add(5);
            arrayList.Add(36);
            foreach (object o in arrayList)
            {
                Console.WriteLine(o);
            }

            arrayList.Sort();
            foreach (object o in arrayList)
            {
                Console.WriteLine(o);
            }

        }
    }
}
