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

        public IQueryable<RoomDetail> GetAllRooms()
        {
            return db.RoomDetailRepo.GetAll();
        }
        public RoomDetail GetRoomById(int Id)
        {
            return db.RoomDetailRepo.GetById(Id);
        }

        public List<Category> GetAllcategories()
        {
            List<Category> categories = new List<Category>();
            IQueryable<RoomCategory> roomCategories= db.RoomCategoryRepo.GetAll();
            foreach (var item in roomCategories)
            {
                Category category = new Category
                {
                    CategoryId = item.RoomCategoryCode,
                    CategoryName = item.RoomCategory1
                };
                categories.Add(category);
            }

            return categories;
        }
        public List<BedNum> GetAllBeds()
        {
            List<BedNum> bedNums = new List<BedNum>();
            IQueryable<Bed>Beds = db.BedRepo.GetAll();
            foreach (var item in Beds)
            {
                BedNum bednum = new BedNum
                {
                   BedsId = item.BedsCode,
                    BedsNum= item.NumberOfBeds
                };
              bedNums.Add(bednum);
            }

            return bedNums;
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

            IEnumerable<int> RoomIds = SearchByDetail(FormData.Category, FormData.Bed);
            foreach (var RoomID in RoomIds)
            {

                List<RoomReservation> roomReservations = searchReservationBYRoom(RoomID);
                if (roomReservations.Count > 0)
                {
                    Room = CheckAVailability(FormData.StartDate, FormData.EndDate, roomReservations);
                    if (Room != 0)
                    {
                        return Room;
                    }
                }
                else
                {
                    return RoomID;
                }
            }

            return Room;
        }


        public double RecervationPrice(BooKingDataForm Data)
        {
            int days = Data.EndDate.Subtract(Data.StartDate).Days;
        double price=  (db.BedRepo.GetById(Data.Bed).BedsPrice) + (db.RoomCategoryRepo.GetById(Data.Category).CategoryPrice);
            return price * days;
        }

        public int CheckForReservationBYRoom(int Id,DateTime StartDate,DateTime EndDate)
        {
            List<RoomReservation> roomReservations = searchReservationBYRoom(Id);
            if (roomReservations.Count > 0)
            {
                int Room = CheckAVailability(StartDate,EndDate, roomReservations);
                if (Room == 0)
                {
                    return 0;
                }
            }
            return Id;
            
        }
    }
}