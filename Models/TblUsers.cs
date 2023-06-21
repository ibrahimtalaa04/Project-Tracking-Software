using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjectTrackingSoftware.Models
{
    public class TblUsers
    {
        public int User_ID { get; set; }
        [MaxLength(50)]
        [Display(Name = "FName")]
        [Required]
        public string FName { get; set; }
        [Display(Name = "LName")]
        [Required]
        public string LName { get; set; }

    
        [EmailAddress]
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required]
        [StringLength(100, ErrorMessage = "minemum length is 4 ", MinimumLength = 4)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        [Required]
        [StringLength(100, ErrorMessage = "minemum length is 4 ", MinimumLength = 4)]
        [Compare("Password", ErrorMessage = "password and confirmation not match")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Date OF Birth")]
        [Required]
        public string DOB { get; set; }

        [Display(Name = "isLoocked")]
        [Required]
        public bool isLoocked { get; set; }

        [Display(Name = "isVerified")]
        [Required]
        public bool isVerified { get; set; }

        [Display(Name = "Access Failed Count")]
        [Required]
        public int AccessFailedCount { get; set; }
        [Display(Name = "Register Date")]
        [Required]
        public string RegisterDate { get; set; }

        [Display(Name = "RegisterCode")]
        [Required]
        public string RegisterCode { get; set; }

        [Display(Name = "confirmCode")]
        [Required]
        public string confirmCode { get; set; }
        [Display(Name = "confirmCode")]
        [Required]
        public string ImgPath { get; set; }


    }
}
