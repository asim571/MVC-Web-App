using System.ComponentModel.DataAnnotations;

namespace Asim_WebApplication1.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="This is Required")]
        [Range(0,100, ErrorMessage ="Id must be between 0 and 100")]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength=2, ErrorMessage ="Name must be between 2 t0 50 characters")]
        public string Name { get; set; }
        [Required]
        [Range(5000, 1200000, ErrorMessage ="Enter the valid salary")]
        public double Salary { get; set; } 

    }
}
