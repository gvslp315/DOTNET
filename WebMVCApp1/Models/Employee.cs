using System.ComponentModel.DataAnnotations;

namespace WebMVCApp1.Models
{
    public class Employee
    {
        //[Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [MaxLength(15)]
        public string? Department { get; set; }

        public int? Salary { get; set; }
    }
}
