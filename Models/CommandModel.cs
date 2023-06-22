namespace ProjectTrackingSoftware.Models
{
    public class CommandModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [MaxLength(200,ErrorMessage ="Controller name must be less than {0}")]
        [Display(Name = "Controller Name")]
        [Required(ErrorMessage ="Controller Name is required")]
        public string? ControllerName { get; set; }


        [MaxLength(200, ErrorMessage = "Action name must be less than {0}")]
        [Display(Name = "Action Name")]
        [Required(ErrorMessage = "Action Name is required")]
        public string? ActionName { get; set; }


        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        [MaxLength(1000, ErrorMessage = "Description must be less than {0}")]
        public string? Description { get; set; }


        [Required(ErrorMessage ="Screen is required")]
        public int ScreenId { get; set; }
    }
}
