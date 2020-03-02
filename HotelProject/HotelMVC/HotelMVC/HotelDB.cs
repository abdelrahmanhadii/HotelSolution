namespace HotelMVC
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelDB : DbContext
    {
        public HotelDB()
            : base("name=HotelDB")
        {
        }

        public virtual DbSet<Bed> Beds { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoomCategory> RoomCategories { get; set; }
        public virtual DbSet<RoomDetail> RoomDetails { get; set; }
        public virtual DbSet<RoomReservation> RoomReservations { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bed>()
                .HasMany(e => e.RoomDetails)
                .WithRequired(e => e.Bed)
                .HasForeignKey(e => e.BedsID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.GuestName)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.NationalID)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.GuestAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .HasMany(e => e.RoomReservations)
                .WithRequired(e => e.Guest)
                .HasForeignKey(e => e.GuestID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoomCategory>()
                .Property(e => e.RoomCategory1)
                .IsUnicode(false);

            modelBuilder.Entity<RoomCategory>()
                .HasMany(e => e.RoomDetails)
                .WithRequired(e => e.RoomCategory)
                .HasForeignKey(e => e.RoomCategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoomDetail>()
                .HasMany(e => e.RoomReservations)
                .WithRequired(e => e.RoomDetail)
                .HasForeignKey(e => e.RoomID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserEmail)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Guests)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserId);
        }
    }
}
