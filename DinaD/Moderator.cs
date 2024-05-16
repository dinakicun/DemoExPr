//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DinaD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Moderator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Moderator()
        {
            this.Activity = new HashSet<Activity>();
        }
    
        public int Id { get; set; }
        public string FullName { get; set; }
        public Nullable<int> SexId { get; set; }
        public string Email { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public Nullable<int> CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> FieldId { get; set; }
        public Nullable<int> ActionId { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Action Action { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activity { get; set; }
        public virtual Country Country { get; set; }
        public virtual Field Field { get; set; }
        public virtual Sex Sex { get; set; }
    }
}
