using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Configuration;

namespace DAL.Models
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=DefaultConnection") {

        }

        //entities
        public DbSet<Student> Students { get; set; }

    }
}