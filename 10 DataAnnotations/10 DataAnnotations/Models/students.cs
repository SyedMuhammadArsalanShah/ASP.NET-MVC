using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _10_DataAnnotations.Models {
     [ Table("information2")]



public class Students
    {

    [Key]
    [ScaffoldColumn(false)]
    public int StudentID { get; set; }
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
    [Display(Name = "Student Name")]
    public string Name { get; set; }
    [MaxLength(3), MinLength(1)]
    [Required(ErrorMessage = "Please enter marks")]
        [DataType(DataType.Text)]
        public string Marks { get; set; }
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Please enter Email ID")]
    [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]

    public string Email { get; set; }
    [Required(ErrorMessage = "Please enter department")]

    public string Department { get; set; }
    [Required(ErrorMessage = "Please enter Mobile No")]
    [Display(Name = "Contact Number")]
    [DataType(DataType.PhoneNumber)]
    public int Mobile { get; set; }
}


    }
