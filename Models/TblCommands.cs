using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjectTrackingSoftware.Models
{
    public class TblCommands
    {
        public int Command_ID { get; set; }
        [MaxLength(50)]
        [Display(Name = "Command Name")]
        [Required]
        public string CommandName { get; set; }

     
        public int ScreenID { get; set; }

    }
}


