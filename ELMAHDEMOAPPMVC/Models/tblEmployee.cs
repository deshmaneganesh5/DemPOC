using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ELMAHDEMOAPPMVC.Models
{
    public class tblEmployee
    {
        [Display (Name ="id")]

        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Employee name")]
        public string EmpName { get; set; }

        [Required (ErrorMessage ="Enter Date of birth")]
        public string DOB { get; set; }

        [Required (ErrorMessage = "Enter department")]
        public string Department { get; set; }

        [Required (ErrorMessage = "Enter employee id")]
        public string Employeeid { get; set; }

    }
}