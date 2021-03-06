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
    
    public partial class LogsBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LogsBase()
        {
            this.ChangesLogs = new HashSet<ChangesLog>();
            this.ExceptionLogs = new HashSet<ExceptionLog>();
        }
    
        public int LogID { get; set; }
        public string Operation { get; set; }
        public string LogLevel { get; set; }
        public System.DateTime Time { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChangesLog> ChangesLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExceptionLog> ExceptionLogs { get; set; }
    }
}
