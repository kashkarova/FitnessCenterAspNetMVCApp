//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessCenterAspNetMVCApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        public int contr_id { get; set; }
        public int service_id { get; set; }
        public int coach_id { get; set; }
        public int contr_salary { get; set; }
    
        public virtual Coach Coach { get; set; }
        public virtual Service Service { get; set; }
    }
}
