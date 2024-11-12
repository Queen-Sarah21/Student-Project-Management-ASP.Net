using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMTIWebSite.Models
{
    public class AssignmentMetadata
    {

       
        [Display(Name = "Assignment Date")]
        public DateTime AssignmentDate { get; set; }
    }
}