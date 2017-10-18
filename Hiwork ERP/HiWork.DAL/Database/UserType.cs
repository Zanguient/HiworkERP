//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HiWork.DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserType()
        {
            this.UserInformations = new HashSet<UserInformation>();
        }
    
        public long Id { get; set; }
        public string Name_en { get; set; }
        public string Name_jp { get; set; }
        public string Name_kr { get; set; }
        public string Name_cn { get; set; }
        public string Name_fr { get; set; }
        public string Name_tl { get; set; }
        public string Description_en { get; set; }
        public string Description_jp { get; set; }
        public string Description_kr { get; set; }
        public string Description_cn { get; set; }
        public string Description_fr { get; set; }
        public string Description_tl { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInformation> UserInformations { get; set; }
    }
}