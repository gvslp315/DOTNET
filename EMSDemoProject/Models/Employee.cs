using System.ComponentModel.DataAnnotations;

namespace EMSDemoProject.Models
{
    public class Employee
    {
        [Key]
        public int empId { get; set; }

        public string empName { get; set; }

        public int empSalary { get; set; }
    }
}
