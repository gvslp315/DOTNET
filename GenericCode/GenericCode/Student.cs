using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericCode
{
    internal class Student
    {
        public int Id { get; set; }

        public string name { get; set; }
        public int age { get; set; }

        static void Main(string[] args)
        {
            List<Student> student = new List<Student>()
            {
                new Student() { Id = 1, name = "mani", age = 3 },
                new Student() { Id = 45, name = "gowtham", age = 24 },
                new Student() { Id = 67, name = "laskshmi", age = 5 },
                new Student() { Id =36, name = "binay", age = 10 },
                new Student() { Id = 14, name = "abhi", age = 15 },

            };
           var stdlist= student.OrderBy(s => s.name).ThenBy(s => s.age);

            foreach(Student s in stdlist)
            {
                Console.WriteLine(s.Id+"  "+s.name);

            }
            var stdlist1 = student.OrderBy(s => s.name).ThenByDescending(s => s.Id);

            foreach (Student s in stdlist1)
            {
                Console.WriteLine(s.Id + "  " + s.name);

            }


        }

    }
}
