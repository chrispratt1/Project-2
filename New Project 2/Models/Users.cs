using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace New_Project_2.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int userID { get; set; }

        [Required(ErrorMessage = "Please enter an email address")]
        public string userEmail { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        public string userPassword { get; set; }

        [Required(ErrorMessage = "Please enter a first name")]
        public string userFirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        public string userLastName { get; set; }
    }
}