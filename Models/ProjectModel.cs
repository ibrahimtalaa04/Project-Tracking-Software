namespace ProjectTrackingSoftware.Models
{
    public class ProjectModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }


        [MaxLength(100,ErrorMessage ="Title must be less than {0}")]
        [Display(Name = "Title")]
        [Required(ErrorMessage ="Title is required")]
        public string? Title { get; set; }

        [MaxLength(5000,ErrorMessage ="Description must be less than {0}")]
        [Display(Name = "Description")]
        [Required(ErrorMessage ="Description is required")]
        public string? Description { get; set; }


        [Display(Name = "Completion Percentage")]
        public double CompletionPercentage { get; set; }
    }
}
