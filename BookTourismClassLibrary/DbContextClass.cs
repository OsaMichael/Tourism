using BookTourismClassLibrary.BannerManagement;
using BookTourismClassLibrary.BookingManagement;
using BookTourismClassLibrary.CompanyManagement;
using BookTourismClassLibrary.FeedbackManagement;
using BookTourismClassLibrary.HistoryManagement;
using BookTourismClassLibrary.LocationManagement;
using BookTourismClassLibrary.TourManagement;
using BookTourismClassLibrary.UserManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTourismClassLibrary
{
  public  class DbContextClass : DbContext
    {
        public DbContextClass() : base("Dbconnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<MainBanner> MainBanners { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Tour> Tours { get; set; }


    }
}
