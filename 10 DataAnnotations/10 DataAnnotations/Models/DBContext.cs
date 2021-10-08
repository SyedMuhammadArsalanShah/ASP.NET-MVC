using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _10_DataAnnotations.Models
{
    public class DBContext :DbContext
    {
        public DbSet<Students>  students { get; set; }
    }
}