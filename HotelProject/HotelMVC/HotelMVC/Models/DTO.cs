using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelMVC.Models
{

    public class BooKingDataForm
    {
        public int Category { get; set; }
        public int Bed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    public class BooKingForm
    {
        public List<Category> categories { get; set; }
        public List<BedNum> Beds { get; set; }
    }

    public class ConfirmBooking
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public RoomsList Room { get; set; }
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
    public class RoomsList
    {
        public int RoomId { get; set; }
        public int RoomNum { get; set; }
    }
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
    public class BedNum
    {
        public int BedsId { get; set; }
        public int BedsNum { get; set; }
    }

    public class AdminReservationData
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string NationaltyID { get; set; }
        public int CategoryID { get; set; }
        public int NumOfBedId { get; set; }
    }
    public class AdminConfirmReservation
    {
        public int GuestCode { get; set; }
        public string GuestName { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public string GuestAddress { get; set; }
        public double TotalPrice { get; set; }
        public RoomsList Room { get; set; }

    }

    public class AdminNewReservation
    {
        public int GuestCode { get; set; }
        public string GuestName { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public string GuestAddress { get; set; }
        public string NationalID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TotalPrice { get; set; }
        public int RoomID { get; set; }
    }

    public class AdminManageReservation
    {
        public int ReservationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
     }


    public class AdminRoomReservation
    {
        public string NationalId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RoomId { get; set; }
    }

}