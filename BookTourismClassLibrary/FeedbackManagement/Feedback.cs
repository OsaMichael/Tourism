﻿using BookTourismClassLibrary.TourManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTourismClassLibrary.FeedbackManagement
{
   public class Feedback
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public string Message { get; set; }

        public string DateEntered { get; set; }

        public Tour Tour { get; set; }
    }
}
