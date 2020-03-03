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
    public class HomeController : Controller
    {
        UserServic UserStore;
        GuestService GuestStore;

        public HomeController(UserServic _UserStore, GuestService _GuestStore)
        {
            UserStore = _UserStore;
            GuestStore = _GuestStore;
        }

        public ActionResult Index()
        {
            return View();
        }

     

       
        [HttpGet]
        public ActionResult LogIn()
        {
          

            return View();
        }
        [HttpPost]
        public ActionResult LogIn(LogIn Data)
        {
            User user = UserStore.Login(Data);
            if (user != null)
            {
                if (user.UserPassword != null)
                {
                    return View("Index");
                }
                else if (user.UserPassword == null)
                {
                    Data.PassWord = "Invalid Password";
                    return View("LogIn", Data);
                }
            }
              return View("Register");

        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task <ActionResult> Register(RegisterUserGuest Data)
        {
            User user;
            Guest guest;
             user = UserStore.checkEmail(Data.Email);
            if (user == null)
            {
                guest = GuestStore.GetGuestByNationalId(Data.NationalID);
                if (guest == null)
                {

                    int result = await UserStore.AddUser(user=new User {
                        UserEmail =Data.Email,
                        UserPassword =Data.PassWord,
                        RoleId =2 });
                    if (result != 0)
                    {
                        int result2 = await GuestStore.AddGuest(guest=new Guest {
                            UserId=user.UserCode,
                            GuestName=Data.GuestName,
                            PhoneNumber=Data.PhoneNumber,
                            NationalID=Data.NationalID,
                            Nationality=Data.Nationality,
                            Gender=Data.Gender,
                            GuestAddress=Data.GuestAddress
                        });
                        if (result2 != 0)
                        { return View("Index"); }

                    }
                }
            }
            
            return View("LogIn");
        }

    }
}