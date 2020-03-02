namespace HotelMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoomDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoomDetail()
        {
            RoomReservations = new HashSet<RoomReservation>();
        }

        [Key]
        public int RoomDetailscode { get; set; }

        public int RoomNumber { get; set; }

        public int BedsID { get; set; }

        public int RoomCategoryID { get; set; }

        public virtual Bed Bed { get; set; }

        public virtual RoomCategory RoomCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomReservation> RoomReservations { get; set; }
    }
}
