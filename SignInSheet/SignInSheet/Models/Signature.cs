using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignInSheet.Models
{
    public class Signature
    {

        [Key]
        public int id { get; set; }

        [Display (Name = "First Name")]
        [Required (ErrorMessage = "Field is required")]
        public string firstName { get; set; }

        [Display (Name = "Last Name")]
        [Required (ErrorMessage = "Field is required")]
        public string lastName { get; set; }

        [Display (Name = "Email Address")]
        [EmailAddress]
        public string email { get; set; }
    }
}