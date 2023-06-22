namespace ProjectTrackingSoftware.Models
{
    public class GroupPremissionModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }


        [MaxLength(50,ErrorMessage ="Group title must be less than {0}")]
        [Display(Name = "Group Title")]
        [Required(ErrorMessage ="Group Title is required")]
        public string? Title { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage ="Description is required")]
        public string? Description { get; set; }
    }
}
