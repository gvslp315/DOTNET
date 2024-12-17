using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS_Entity.Models
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Doctor")]

        public string? DoctorName { get; set; }
        [Required]
        [DisplayName("Qualification")]

        public string? Qualification { get; set; }
        [Required]
        
        [DisplayName("Specialist")]
        public string? Specialist { get; set; }

        [ForeignKey("Medical")]
        public int mId { get; set; }
    }
}
