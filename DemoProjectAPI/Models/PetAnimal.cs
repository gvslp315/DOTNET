using System.ComponentModel.DataAnnotations;

namespace DemoProjectAPI.Models
{
    public class PetAnimal
    {
        [Key]
        public int petId { get; set; }

        public string petName { get; set; }

        public string petType { get; set; }

        public string gender { get; set; }

        public bool IsVeg { get; set; }
    }
}
