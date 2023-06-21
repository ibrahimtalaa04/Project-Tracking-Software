using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjectTrackingSoftware.Models
{
    public class TblTasks
    {
        public int Task_ID { get; set; }

        [MaxLength(50)]
        [Display(Name = "Title")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Lable")]
        [Required]
        public string Lable { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Date")]
        [Required]
        public string Date { get; set; }

        [Display(Name = "Priority")]
        [Required]
        public int Priority { get; set; }


        [Display(Name = "Time")]
        [Required]
        public string Time { get; set; }

        [Display(Name = "ProjectID")]
        [Required]
        public int Project_ID { get; set; }


        [Display(Name = "StatusID")]
        [Required]
        public int StatusID { get; set; }

    }
}

