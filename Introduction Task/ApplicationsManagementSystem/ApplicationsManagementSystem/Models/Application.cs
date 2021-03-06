//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicationsManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Application()
        {
            this.ApplicationSettings = new HashSet<ApplicationSetting>();
            this.SpecialityApplications = new HashSet<SpecialityApplication>();
        }
    
        public int ApplicationID { get; set; }
        public int PaymentTypeID { get; set; }
        public int UserID { get; set; }
        public int Submitted { get; set; }
    
        public virtual User User { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationSetting> ApplicationSettings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialityApplication> SpecialityApplications { get; set; }
    }
}
