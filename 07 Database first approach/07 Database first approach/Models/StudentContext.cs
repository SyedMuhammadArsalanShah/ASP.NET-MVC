using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _07_Database_first_approach.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> students { get; set; }


    }
}