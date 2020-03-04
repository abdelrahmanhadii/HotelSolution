using HotelMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelMVC.Controllers
{
    public class GuestController : Controller
    {
        GuestService GuestStore;

        public GuestController( GuestService _GuestStore)
        {
           
            GuestStore = _GuestStore;
        }

        // GET: Guest
        public ActionResult Index()
        {
            return View();
        }


    }
}