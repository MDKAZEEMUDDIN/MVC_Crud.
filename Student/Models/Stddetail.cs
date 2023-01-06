using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Student.Models
{
    public class Stddetail
    {
        [Key]
        public int Id {get; set; }
        [Required]
        public string? Name { get; set; }       
        [Required]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Please Enter Valid Mobile Number.")]
        public string?  phonenum { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string? email { get; set; }
        [Required]
        public string? city { get; set; }
    }
}
