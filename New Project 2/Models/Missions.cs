using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace New_Project_2.Models
{
    [Table("Missions")]
    public class Missions
    {
        [Key]
        [Required(ErrorMessage = "Please enter a missionID")]
        public int missionID { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string missionName { get; set; }

        [Required(ErrorMessage = "Please enter a Mission President")]
        public string presidentName { get; set; }

        [Required(ErrorMessage = "Please enter an address")]
        public string missionAddress { get; set; }

        [Required(ErrorMessage = "Please enter a language")]
        public string missionLanguage { get; set; }

        [Required(ErrorMessage = "Please enter a climate")]
        public string missionClimate { get; set; }

        [Required(ErrorMessage = "Please enter a religion")]
        public string missionReligion { get; set; }

        [Required(ErrorMessage = "Please enter a flag")]
        public string missionFlag { get; set; }
    }
}