using System.ComponentModel.DataAnnotations;

namespace FinalProjectCsharp.Model
{
    public class Patient
    {
        [Key]
        public int pId {  get; set; }

        public string pName {  get; set; }

        public string appDate {  get; set; }

        public string pMobile {  get; set; }

        public string pDisease {  get; set; }
    }
}
