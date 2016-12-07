using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace New_Project_2.Models
{
    [Table("MissionQuestions")]
    public class MissionQuestions
    {
        [Key]
        public int questionID { get; set; }

        [ForeignKey("missionID")]
        [Required(ErrorMessage = "Please enter a missionID")]
        public int missionID { get; set; }

        [ForeignKey("userID")]
        [Required(ErrorMessage = "Please enter a userID")]
        public int userID { get; set; }

        [Required(ErrorMessage = "Please enter a question")]
        public string question { get; set; }

        [Required(ErrorMessage = "Please enter an answer")]
        public string answer { get; set; }
    }
}