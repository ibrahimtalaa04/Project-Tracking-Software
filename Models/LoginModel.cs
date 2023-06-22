using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjectTrackingSoftware.Models
{
    public class LoginModel
    {
     
            public int Id { get; set; }
            [EmailAddress]
            [Display(Name = "Email")]
            [Required]
            public string Email { get; set; }
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            [Required]
            [StringLength(100, ErrorMessage = "minemum length is 4 ", MinimumLength = 4)]
            public string Password { get; set; }
            public bool RemmemberMe { get; set; }
        
    }
}
