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
    
    public partial class SpecialityTestOption
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecialityTestOption()
        {
            this.GroupedSpecialities = new HashSet<GroupedSpeciality>();
            this.OptionalSubjectsGroups = new HashSet<OptionalSubjectsGroup>();
            this.ProfileSubjectsGroups = new HashSet<ProfileSubjectsGroup>();
        }
    
        public int SpecialityTestOptionID { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupedSpeciality> GroupedSpecialities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OptionalSubjectsGroup> OptionalSubjectsGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileSubjectsGroup> ProfileSubjectsGroups { get; set; }
    }
}