namespace ProjectTrackingSoftware.Models
{
    public class TaskModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [MaxLength(100,ErrorMessage ="Title must be less than {0}")]
        [Display(Name = "Title")]
        [Required(ErrorMessage ="Title is required")]
        public string? Title { get; set; }

        [Display(Name = "Label")]
        [Required(ErrorMessage = "Label is required")]
        [MaxLength(100, ErrorMessage = "Label must be less than {0}")]
        public string? Label { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        [MaxLength(1000, ErrorMessage = "Description must be less than {0}")]
        public string? Description { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage ="Due date is required")]
        public DateTime DueDate { get; set; }

        [Display(Name = "Priority")]
        public string? Priority { get; set; }


        [Display(Name = "Tracking Time")]
        public TimeOnly TrackingTime { get; set; }

        public DateTime? LastStartDate { get; set; }
        public DateTime? LastEndDate { get; set; }

        [Display(Name = "Project")]
        [Required(ErrorMessage ="Project is required")]
        public int ProjectId { get; set; }


        [Display(Name = "Status")]
        [Required(ErrorMessage ="Status is required")]
        public int StatusId { get; set; }

    }
}
