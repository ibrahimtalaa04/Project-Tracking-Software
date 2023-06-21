using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjectTrackingSoftware.Models
{
    public class TblStatus
    {
        public int Status_ID { get; set; }
        [MaxLength(50)]
        [Display(Name = "Lable")]
        [Required]
        public string Lable { get; set; }
    }
}
