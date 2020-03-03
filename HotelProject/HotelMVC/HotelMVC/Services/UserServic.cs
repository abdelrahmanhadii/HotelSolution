using HotelMVC.DAL;
using HotelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HotelMVC.Services
{
    public class UserServic
    {
        public IUnitOfWork db;

        public UserServic(IUnitOfWork _db)
        {
            db = _db;
        }

        public User checkEmail(string Email)
        {
            return db.UserRepo.Find(a => a.UserEmail == Email).FirstOrDefault();
        }
        public User Login(LogIn LoginData)
        {
            User user = new User
            {
                UserPassword = LoginData.PassWord
            };
             user = checkEmail(LoginData.Email);
            if (user != null)
            {
                if (user.UserPassword != LoginData.PassWord)
                {
                    user.UserPassword = null;
                }
                
            }


            return user;
          
        }

        public async Task<int> AddUser(User user)
        {

            db.UserRepo.Create(user);
            int Check = await db.Save();
            return Check;

        }


    }
}