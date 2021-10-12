using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _11_Auth_MVC.Models
{
    public class Db :DbContext
    {
        public DbSet<Signup> Signups { get; set; }
    }
}