using HotelMVC.Models;
using HotelMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HotelMVC.Controllers
{
    public class AdminController : Controller
    {
        RoomService RoomStore;
        GuestService GuestStore;
        RoomReservationService RoomReservationstore;


        public AdminController(RoomService _RoomStore, GuestService _GuestStore, RoomReservationService _RoomReservationstore)
        {
            RoomStore = _RoomStore;
            GuestStore = _GuestStore;
            RoomReservationstore = _RoomReservationstore;

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


        [HttpPost]
        public async Task<ActionResult> NewReservation(AdminNewReservation Data)
        {
            int result;
            Guest guest = new Guest {
                GuestCode=0,
                GuestName=Data.GuestName,
                NationalID=Data.NationalID,
                Nationality=Data.Nationality,
                PhoneNumber=Data.PhoneNumber,
                Gender=Data.Gender,
                GuestAddress=Data.GuestAddress
            };

            if (Data.GuestCode != 0)
            {
                guest.GuestCode = Data.GuestCode;
                result = await GuestStore.UpdateGuest(guest.GuestCode, guest);
            }
            else
            {
                 result = await GuestStore.AddGuest(guest);
            }
            guest = GuestStore.GetGuestByNationalId(Data.NationalID);
            RoomReservation roomReservation = new RoomReservation {
                StartDate=Data.StartDate,
                EndDate=Data.EndDate,
                RoomID=Data.RoomID,
                GuestID=guest.GuestCode
            };
            result= await RoomReservationstore.CreatNewReservation(roomReservation);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult GetRoomReservation(int ID)
        {
            List<AdminManageReservation> Data = new List<AdminManageReservation>();
            if (ID != 0)
            {
                List<RoomReservation> roomsList=RoomStore.searchReservationBYRoom(ID);
                if (roomsList != null)
                {
                   
                    foreach (var item in roomsList)
                    {
                        AdminManageReservation reservation = new AdminManageReservation {
                            StartDate = item.StartDate,
                            EndDate=item.EndDate,
                            ReservationId=item.ReservationCode
                        };
                        Data.Add(reservation);
                    }
                }


            }
            return Json(Data, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult RoomNewReservation(AdminRoomReservation Data)
        {
            AdminConfirmReservation ConfirmReservation = new AdminConfirmReservation();
            int result = RoomStore.CheckForReservationBYRoom(Data.RoomId, Data.StartDate, Data.EndDate);

            if (result > 0)
            {
                RoomDetail RoomData = RoomStore.GetRoomById(result);
                ConfirmReservation.Room = new RoomsList { RoomId = RoomData.RoomDetailscode, RoomNum = RoomData.RoomNumber };
                ConfirmReservation.TotalPrice = RoomStore.RecervationPrice(new BooKingDataForm { StartDate = Data.StartDate, EndDate = Data.EndDate, Category = RoomData.RoomCategoryID, Bed = RoomData.BedsID });
            }

            Guest Guest = GuestStore.GetGuestByNationalId(Data.NationalId);
            if (Guest != null)
            {
                ConfirmReservation.Gender = Guest.Gender;
                ConfirmReservation.GuestAddress = Guest.GuestAddress;
                ConfirmReservation.GuestCode = Guest.GuestCode;
                ConfirmReservation.GuestName = Guest.GuestName;
                ConfirmReservation.Nationality = Guest.Nationality;
                ConfirmReservation.PhoneNumber = Guest.PhoneNumber;

            }
            return Json(ConfirmReservation, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public async Task <ActionResult> DeleteReservation(int Id)
        {
            int Result = await RoomReservationstore.DeleteReservation(Id);
            return Json(Result, JsonRequestBehavior.AllowGet);
        }

    }
}