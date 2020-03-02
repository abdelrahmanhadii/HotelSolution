namespace HotelMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomReservation")]
    public partial class RoomReservation
    {
        [Key]
        public int ReservationCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        public int GuestID { get; set; }

        public int RoomID { get; set; }

        public virtual Guest Guest { get; set; }

        public virtual RoomDetail RoomDetail { get; set; }
    }
}
