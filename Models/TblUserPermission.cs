using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjectTrackingSoftware.Models
{
    public class TblUserPermission
    {
        public int ID { get; set; }
        [MaxLength(50)]
        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }


    }
}
