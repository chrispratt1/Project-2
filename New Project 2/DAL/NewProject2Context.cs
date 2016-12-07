using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using New_Project_2.Models;
using System.Data.Entity;

namespace New_Project_2.DAL
{
    public class NewProject2Context : DbContext
    {
        public NewProject2Context() : base("NewProject2Context")
        {

        }

        public DbSet<Users> User { get; set; }
        public DbSet<Missions> Mission { get; set; }
        public DbSet<MissionQuestions> MissionQuestion { get; set; }
    }
}