﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookTourismWeb.Models
{
    public class DDViewModel
    {
        public string Name { get; set; }

        public string Label { get; set; }

        public IEnumerable<SelectListItem> Values { get; set; }

    }
}