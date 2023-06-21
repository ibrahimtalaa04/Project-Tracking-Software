using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjectTrackingSoftware.Models
{
    public class TblScreens
    {
        
        public int screen_ID { get; set; }

        [MaxLength(50)]
        [Display(Name = "controller")]
        [Required]
        public string controller { get; set; }
    }
}
