﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidle.Models;

namespace Vidle.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Customer> Customers { get; set; }
        public Movie Movie { get; set; }
    }
}