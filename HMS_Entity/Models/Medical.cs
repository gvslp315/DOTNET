using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HMS_Entity.Models
{
    public class Medical
    {
        [Key]
        public int mId {  get; set; }

        [Required]
        [DisplayName("Shop Name")]
        public string mName { get; set; }

        [Required]
        [DisplayName("Shop Location")]
        public string mLocation { get; set; }

        [Required]
        [DisplayName("Shop Special")]
        public string mSpecial { get; set; }

        
    }
}
