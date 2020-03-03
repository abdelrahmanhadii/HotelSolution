using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelMVC.Models
{
   
    public class BooKingDataForm
    {
     public  int Category { get; set; }
     public  int Bed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    public class BooKingForm
    {
        public IQueryable<RoomCategory> categories { get; set; }
        public IQueryable<Bed> Beds { get; set; }
    }

    public class ConfirmBooking
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public RoomDetail Room { get; set; }
        public double Price { get; set; }
             
    }
    public class LogIn
    {
        public string Email { get; set; }
        public string PassWord { get; set; }
        

    }
    public class RegisterUserGuest
    {
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string GuestName { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string NationalID { get; set; }
        public string Gender { get; set; }
        public string GuestAddress { get; set; }

    }

}