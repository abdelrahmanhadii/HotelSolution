using HotelMVC.DAL;
using HotelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HotelMVC.Services
{
    public class RoomService
    {

         IUnitOfWork db;
        
        public RoomService(IUnitOfWork _db)
        {
            db = _db;
        }

        public IQueryable<RoomCategory> GetAllcategories()
        {
            return db.RoomCategoryRepo.GetAll();
        }
        public IQueryable<Bed> GetAllBeds()
        {
            return db.BedRepo.GetAll();
        }

        public IEnumerable<int> SearchByDetail(int Category, int NumOfBed)
        {
            IEnumerable<int> RoomIds = db.RoomDetailRepo.Find(a => a.BedsID==NumOfBed&&a.RoomCategoryID==Category).Select(a=>a.RoomDetailscode);
          

            return RoomIds ;

        }

        public List<RoomReservation> searchReservationBYRoom(int RoomId)
        {
            IQueryable<RoomReservation> RoomReservation = db.RoomReservationRepo.GetAll();
            List<RoomReservation> roomReservationslist = new List<RoomReservation>();
            foreach (var item in RoomReservation)
            {
                
                    if (  item.RoomID==RoomId)
                    {
                        roomReservationslist.Add(item);
                    }


            }
            return roomReservationslist;
        }

        public int CheckAVailability(DateTime Start, DateTime End, List<RoomReservation> roomReservations)
        {
            int Result=roomReservations.First().RoomID;

            foreach (var Room in roomReservations)
            {
                if (Room.StartDate < End && Start <Room.EndDate)
                {
                    Result = 0;
                }
            }
            return Result;
        }

        public int CheckForReservation(BooKingDataForm FormData)


        {
            int Room = 0;

            IEnumerable<int> RoomIds = SearchByDetail(FormData.Category,FormData.Bed);
            foreach (var  RoomID in RoomIds)
            {

               List<RoomReservation> roomReservations=  searchReservationBYRoom(RoomID);

                Room = CheckAVailability(FormData.StartDate,FormData.EndDate,roomReservations);
                if (Room!=0)
                {
                    return Room;
                }
            }

            return Room;
        }



    }
}