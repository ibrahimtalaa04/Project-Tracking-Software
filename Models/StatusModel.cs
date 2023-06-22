namespace ProjectTrackingSoftware.Models
{
    public class StatusModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }


        [MaxLength(50,ErrorMessage ="Title must be less than {0}")]
        [Display(Name = "Title")]
        [Required(ErrorMessage ="Title is required")]
        public string? Title { get; set; }
    }
}
