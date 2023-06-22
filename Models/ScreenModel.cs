namespace ProjectTrackingSoftware.Models
{
    public class ScreenModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [MaxLength(50)]
        [Display(Name = "Title")]
        [Required]
        public string? Title { get; set; }


        [MaxLength(50)]
        [Display(Name = "Path")]
        [Required]
        public string? Path { get; set; }

        [MaxLength(100, ErrorMessage = "Description must be less than {0}")]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }
    }
}
