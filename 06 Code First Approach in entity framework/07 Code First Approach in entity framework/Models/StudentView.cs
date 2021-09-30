using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _07_Code_First_Approach_in_entity_framework.Models
{
    public class StudentView
    {
        public List<Student> getAllRecord()
        {
            StudentContext obj = new StudentContext();
            return obj.students.ToList();

        }
    }
}