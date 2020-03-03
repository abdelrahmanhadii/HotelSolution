using HotelMVC.Models;
using HotelMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelMVC.Controllers
{
    public class RoomController : Controller
    {
        RoomService RoomStore;

        public RoomController(RoomService _RoomStore)
        {
            RoomStore = _RoomStore;
        }
       


        // GET: Room
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Booking()
        {
            BooKingForm FormData = new BooKingForm {
                categories = RoomStore.GetAllcategories(),
                Beds= RoomStore.GetAllBeds()
            };
       

            return View(FormData);
        }
        [HttpPost]
        public ActionResult ConfirmBooking(BooKingDataForm FormData)
        {
            if (FormData.StartDate < FormData.EndDate)
            {
                int result = RoomStore.CheckForReservation(FormData);
                if (result > 0)
                {
                    ConfirmBooking Data = new ConfirmBooking
                    {
                        StartDate = FormData.StartDate,
                        EndDate = FormData.EndDate,
                        Room = RoomStore.GetRoomById(result),
                        Price = RoomStore.RecervationPrice(FormData)
                    };
                    return View (Data);
                }
            }
            return View();

        }


    } 
}