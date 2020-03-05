using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace HotelApplication
{
    static class Global
    {
        private static  RestClient _client=new RestClient("http://localhost:51650");

        public static RestClient client
        {
            get { return _client; }
            set { _client = value; }
        }
    }
    public class LogIn
    {
        public string Email { get; set; }
        public string PassWord { get; set; }
    }
    public class Room
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
    public class HomeData
    {
        public List<Room>Rooms { get; set; }
        public List<Category> Categories { get; set; }
        public List<BedNum> Beds { get; set; }
    }

    public class CheckReservationData
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string NationaltyID { get; set; }
        public int CategoryID { get; set; }
        public int NumOfBedId { get; set; }
    }
    public class ConfirmReservationData
    {
        public int GuestCode { get; set; }
        public string GuestName { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public string GuestAddress { get; set; }
        public double TotalPrice { get; set; }
        public Room Room { get; set; }

    }

  

   public class ReservationForm
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
      
        public int RoomNum { get; set; }

    }

    public class NewReservation
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

    public class ManageReservation
    {
        public int ReservationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class NewRoomReservation
    {
        public string NationalId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RoomId { get; set; }
    }

}
