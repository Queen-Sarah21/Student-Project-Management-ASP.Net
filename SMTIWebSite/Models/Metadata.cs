using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SMTIWebSite.Models
{
    public class StudentMetadata  //Metadata
    {
        [Required]
        [Display(Name = "Student Number")]
        public int StudentNumber { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
       
        [Display(Name = "Email")]
        public string Email { get; set; }

        
      


    }

}