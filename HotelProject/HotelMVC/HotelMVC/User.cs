namespace HotelMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Guests = new HashSet<Guest>();
        }

        [Key]
        public int UserCode { get; set; }

        [Required]
        [StringLength(40)]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(20)]
        public string UserPassword { get; set; }

        public int RoleId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Guest> Guests { get; set; }

        public virtual Role Role { get; set; }
    }
}
