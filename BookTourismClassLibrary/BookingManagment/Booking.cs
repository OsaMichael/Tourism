using BookTourismClassLibrary.TourManagement;
using BookTourismClassLibrary.UserManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTourismClassLibrary.BookingManagement
{
  
        public class Booking
        {
            [Key]
            public int Id { get; set; }

            public int? UserId { get; set; }

            public virtual User User { get; set; }

            public Tour Tour { get; set; }

        }
    }

