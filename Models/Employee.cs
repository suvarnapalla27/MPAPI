using System.ComponentModel.DataAnnotations;

namespace APIProject.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Please enter the characters less than 10.")]
        public string EmpName { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Designation { get; set; }
        [Range(1000, 100000, ErrorMessage = "salary must be between 1000 and 100000.")]
        public float salary { get; set; }
    }
}
