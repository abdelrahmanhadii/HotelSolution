using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HotelMVC.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HotelDB _context;

        private GenericRepository<Bed> _BedRepo;

        private GenericRepository<Guest> _GuestRepo ;

        private GenericRepository<Role> _RoleRepo ;

        private GenericRepository<RoomCategory> _RoomCategoryRepo ;

        private GenericRepository<RoomDetail> _RoomDetailRepo;

        private GenericRepository<RoomReservation> _RoomReservationRepo ;

        private GenericRepository<User> _UserRepo ;

        public UnitOfWork(HotelDB context)
        {
            _context = context;
        }
        public GenericRepository<Bed> BedRepo
        {
            get
            {
                if (_BedRepo == null)
                {
                    _BedRepo = new GenericRepository<Bed>(_context);
                }
                return _BedRepo;
            }
        }
        public GenericRepository<Guest> GuestRepo
        {
            get
            {
                if (_GuestRepo == null)
                {
                    _GuestRepo = new GenericRepository<Guest>(_context);
                }
                return _GuestRepo;
            }
        }
        public GenericRepository<Role> RoleRepo
        {
            get
            {
                if (_RoleRepo == null)
                {
                    _RoleRepo = new GenericRepository<Role>(_context);
                }
                return _RoleRepo;
            }
        }
        public GenericRepository<RoomCategory> RoomCategoryRepo
        {
            get
            {
                if (_RoomCategoryRepo == null)
                {
                    _RoomCategoryRepo = new GenericRepository<RoomCategory>(_context);
                }
                return _RoomCategoryRepo;
            }
        }
        public GenericRepository<RoomDetail> RoomDetailRepo
        {
            get
            {
                if (_RoomDetailRepo == null)
                {
                    _RoomDetailRepo = new GenericRepository<RoomDetail>(_context);
                }
                return _RoomDetailRepo;
            }
        }
        public GenericRepository<RoomReservation> RoomReservationRepo
        {
            get
            {
                if (_RoomReservationRepo == null)
                {
                    _RoomReservationRepo = new GenericRepository<RoomReservation>(_context);
                }
                return _RoomReservationRepo;
            }
        }
        public GenericRepository<User> UserRepo
        {
            get
            {
                if (_UserRepo == null)
                {
                    _UserRepo = new GenericRepository<User>(_context);
                }
                return _UserRepo;
            }
        }
        public Task <int> Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}