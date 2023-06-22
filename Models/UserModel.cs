namespace ProjectTrackingSoftware.Models
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }


        [MaxLength(50, ErrorMessage = "Max length is 50 char")]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is reqired")]
        public string? FirstName { get; set; }


        [Display(Name = "Last Name")]
        [Required(ErrorMessage ="Last Name is required")]
        [MaxLength(50,ErrorMessage ="Max length is 50 char")]
        public string? LastName { get; set; }


        [EmailAddress(ErrorMessage ="Please enter a valid email ")]
        [Display(Name = "Email")]
        [Required(ErrorMessage ="Email is required !")]
        public string? Email { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage ="Password is required ")]
        [StringLength(100, ErrorMessage = "Password must be between {1} and {0}", MinimumLength = 4)]
        public string? Password { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage ="Please confirm your password")]
        [StringLength(100, ErrorMessage = "Password must be between {1} and {0}", MinimumLength = 4)]
        [Compare("Password", ErrorMessage = "password and confirmation not match")]
        [NotMapped]
        public string? ConfirmPassword { get; set; }


        [Display(Name = "Date of birth")]
        [Required(ErrorMessage ="Date of birth is required ")]
        [DataType(DataType.Date,ErrorMessage ="Please write a valid date ")]
        public DateTime Dob { get; set; }

        public bool IsLoocked { get; set; }

        public bool IsVerified { get; set; }

        [Display(Name = "Access Failed Count")]
        public int AccessFailedCount { get; set; }

        [Required(ErrorMessage ="Register date is required")]
        public string? RegisterDate { get; set; }

        [Required(ErrorMessage = "Error!")]
        public string? RegisterCode { get; set; }

        public int resetcount { get; set; }

        [Required(ErrorMessage = "Error!")]
        public string? ConfirmCode { get; set; }


        [Display(Name = "Image")]
        public string? ImgPath { get; set; }

    }
}
