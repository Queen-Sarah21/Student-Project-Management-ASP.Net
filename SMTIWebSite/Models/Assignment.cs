//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMTIWebSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assignment
    {
        public int AssignmentId { get; set; }
        public string ProjectCode { get; set; }
        public int StudentNumber { get; set; }
        public System.DateTime AssignmentDate { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual Student Student { get; set; }
    }
}