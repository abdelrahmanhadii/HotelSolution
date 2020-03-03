using HotelMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HotelMVC.Services
{
    public class GuestService
    {
    
       public IUnitOfWork db;
       
        public GuestService(IUnitOfWork _db)
        {
            db = _db;
        }

        public Guest GetGuestByNationalId(string Id)
        {
          return  db.GuestRepo.Find(a => a.NationalID == Id).FirstOrDefault();
        }
        public async Task<int> AddGuest(Guest Guest)
        {
            
                db.GuestRepo.Create(Guest);
                int Check = await db.Save();
                return Check;
             
        }
        public Guest GetGuestById(int Id)
        {
            return db.GuestRepo.GetById(Id);
        }

    }
}