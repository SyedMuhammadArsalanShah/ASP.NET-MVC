using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Data_Access_by_Entity_Framework.Models
{
    [Table("Info")]
    public class Student
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnic { get; set; }
    }
}