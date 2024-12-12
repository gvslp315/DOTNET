using System.ComponentModel.DataAnnotations;

namespace HMS_Entity.Models
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public string DoctorName { get; set; }
        [Required]
        public string Qualification { get; set; }
        [Required]
        public string Specialist { get; set; }
    }
}
