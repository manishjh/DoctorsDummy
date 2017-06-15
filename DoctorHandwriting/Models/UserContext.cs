using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace DoctorHandwriting.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base(@"Data Source=LP-Manishjha\SQLExpress;Initial Catalog=DoctorDummy;Integrated Security=SSPI;")
        {

        }

        public DbSet<User> Users{get; set;}

        protected override void OnModelCreating( DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.UserID); //primary key


        }
    }
}