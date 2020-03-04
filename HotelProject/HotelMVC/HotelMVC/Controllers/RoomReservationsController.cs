using HotelMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HotelMVC.Controllers
{
    public class RoomReservationsController : Controller
    {

        RoomReservationService RoomReservationStore;
        GuestService GuestStore;
        RoomService RoomStore;

        public RoomReservationsController(RoomReservationService _RoomReservationStore, GuestService _GuestStore, RoomService _RoomStore)
        {
            RoomReservationStore= _RoomReservationStore;
            GuestStore = _GuestStore;
            RoomStore = _RoomStore;
        }

        // GET: RoomReservations
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> NewReservation(RoomReservation Reservation)
        {
            Reservation.GuestID = 1;
            Guest CheckGuest = GuestStore.GetGuestById(Reservation.GuestID);
            if (CheckGuest != null)
            {
                int CheckReservation = await RoomReservationStore.CreatNewReservation(Reservation);
                if (CheckReservation != 0)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult RoomReservationList(int RoomId)
        {
            List<RoomReservation> List = RoomStore.searchReservationBYRoom(RoomId);

            return Json(List, JsonRequestBehavior.AllowGet);
        }
    }
}