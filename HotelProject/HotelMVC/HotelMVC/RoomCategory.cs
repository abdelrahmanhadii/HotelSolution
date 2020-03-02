namespace HotelMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomCategory")]
    public partial class RoomCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoomCategory()
        {
            RoomDetails = new HashSet<RoomDetail>();
        }

        [Key]
        public int RoomCategoryCode { get; set; }

        [Column("RoomCategory")]
        [Required]
        [StringLength(50)]
        public string RoomCategory1 { get; set; }

        public double CategoryPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomDetail> RoomDetails { get; set; }
    }
}
