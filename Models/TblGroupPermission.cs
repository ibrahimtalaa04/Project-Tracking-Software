using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;

namespace ProjectTrackingSoftware.Models
{
    public class TblGroupPermission
    {

        public int group_ID { get; set; }

        [MaxLength(50)]
        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }

    }
}




