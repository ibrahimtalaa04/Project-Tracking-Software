using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;

namespace ProjectTrackingSoftware.Models
{
    public class TblProjects
    {
        public int Project_ID { get; set; }
        [MaxLength(50)]
        [Display(Name = "Title")]
        [Required]
        public string Title { get; set; }
        

        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "completion_percentage")]
        [Required]
        public double completion_percentage { get; set; }



    }
   
}




