using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SMTIWebSite.Models
{
    public class ProMetadata//ProjectMetadata
    {


        [Required]
        [StringLength(6)]
        [Display(Name = "Project Code")]
        public string ProjectCode { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "Project Title")]
        public string ProjectTitle { get; set; }


        [Required]
        [Display(Name = "Due Data")]
        public DateTime DueDate { get; set; }


    }
}