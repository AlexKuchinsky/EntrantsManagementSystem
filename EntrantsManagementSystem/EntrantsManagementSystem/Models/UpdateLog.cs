//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntrantsManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UpdateLog
    {
        public int LogID { get; set; }
        public string Object { get; set; }
        public string PropertyName { get; set; }
        public int UpdateLogID { get; set; }
    
        public virtual Log Log { get; set; }
    }
}
