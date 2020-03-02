using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelMVC.Models
{
    public class BooKingDataForm
    {
     public  int Category;
     public  int Bed;
     public DateTime StartDate;
     public DateTime EndDate;
    }
    public class BooKingForm
    {
        public IQueryable<RoomCategory> categories;
        public IQueryable<Bed> Beds;
    }
}