//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DinaD.Models
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            this.Activities = new HashSet<Activity>();
            this.Events = new HashSet<Event>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public Nullable<int> SexId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> DirectionId { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Direction Direction { get; set; }
        public virtual Role Role { get; set; }
        public virtual Sex Sex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events1 { get; set; }
        public string ImgPath
        {
            get
            {
                string sanitizedImage = Image?.Trim() ?? string.Empty;
                string musicPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users", sanitizedImage);
                return musicPath;
            }
        }

    }
}
