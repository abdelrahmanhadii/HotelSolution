using HotelMVC.Models;
using HotelMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelMVC.Controllers
{
    public class AdminController : Controller
    {
        RoomService RoomStore;
        GuestService GuestStore;


        public AdminController(RoomService _RoomStore, GuestService _GuestStore)
        {
            RoomStore = _RoomStore;
            GuestStore = _GuestStore;

        }
        // GET: Admin
        [HttpGet]
        public ActionResult Index()
        {
            List<RoomsList> Rooms = new List<RoomsList>();
            IQueryable<RoomDetail> AllRooms = RoomStore.GetAllRooms();
            foreach (var Room in AllRooms)
            {
                Rooms.Add(new RoomsList { RoomId = Room.RoomDetailscode, RoomNum = Room.RoomNumber });
            }
            List<Category> categories = RoomStore.GetAllcategories();
            List<BedNum> Beds = RoomStore.GetAllBeds();

            var Data = new { Rooms = Rooms, Categories = categories, Beds = Beds };

            return Json(Data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CheckReservation(AdminReservationData Data)
        {
            AdminConfirmReservation ConfirmReservation = new AdminConfirmReservation();

            Guest Guest = GuestStore.GetGuestByNationalId(Data.NationaltyID);
            if (Guest != null)
            {
                ConfirmReservation.Gender = Guest.Gender;
                ConfirmReservation.GuestAddress = Guest.GuestAddress;
                ConfirmReservation.GuestCode = Guest.GuestCode;
                ConfirmReservation.GuestName = Guest.GuestName;
                ConfirmReservation.Nationality = Guest.Nationality;
                ConfirmReservation.PhoneNumber = Guest.PhoneNumber;

            }

            int result = RoomStore.CheckForReservation(new BooKingDataForm { StartDate = Data.StartDate, EndDate = Data.EndDate, Category = Data.CategoryID, Bed = Data.NumOfBedId });

            if (result > 0)
            {
                RoomDetail RoomData = RoomStore.GetRoomById(result);
                ConfirmReservation.Room = new RoomsList { RoomId = RoomData.RoomDetailscode, RoomNum = RoomData.RoomNumber };
                ConfirmReservation.TotalPrice = RoomStore.RecervationPrice(new BooKingDataForm { StartDate = Data.StartDate, EndDate = Data.EndDate, Category = Data.CategoryID, Bed = Data.NumOfBedId });

            }

            return Json(ConfirmReservation, JsonRequestBehavior.AllowGet);

        }
    }
}