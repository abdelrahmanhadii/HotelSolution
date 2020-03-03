using HotelMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HotelMVC.Services
{
    public class RoomReservationService
    {
        IUnitOfWork db;

        public RoomReservationService(IUnitOfWork _db)

        {
            db = _db;
        }


        public async Task<int> CreatNewReservation(RoomReservation Reservation)
        {
            db.RoomReservationRepo.Create(Reservation);
            int Check = await db.Save();
            return Check;
        }

        public async Task<int> UpdateReservation(RoomReservation Reservation)
        {
            db.RoomReservationRepo.Update(Reservation.ReservationCode,Reservation);
            int Check = await db.Save();
            return Check;
        }
        public async Task<int> DeleteReservation(int id)
        {
            db.RoomReservationRepo.Delete(id);
            int Check = await db.Save();
            return Check;
        }
    }
}