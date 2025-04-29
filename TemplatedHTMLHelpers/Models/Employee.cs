using System.ComponentModel.DataAnnotations;
namespace TemplatedHTMLHelpers.Models

{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name ="Please Enter Your Name")]
        public string Name { get; set; }
        public string email { get; set; }
        public bool Isonline { get; set; }
        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateofBirth{ get; set; }
        [DataType(DataType.Time)]
        public DateTime DateTime {  get; set; }
    }
}
