using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMVC.DAL
{
   public interface IUnitOfWork
    {
        GenericRepository<Bed> BedRepo { get; }
        GenericRepository<Guest> GuestRepo { get; }
        GenericRepository<Role> RoleRepo { get; }
        GenericRepository<RoomCategory> RoomCategoryRepo { get; }
        GenericRepository<RoomDetail> RoomDetailRepo { get; }
        GenericRepository<RoomReservation> RoomReservationRepo { get; }
        GenericRepository<User> UserRepo { get; }


        Task<int> Save();
    }
}
