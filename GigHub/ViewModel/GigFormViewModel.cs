﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GigHub.Models;

namespace GigHub.ViewModel
{
    public class GigFormViewModel
    {
        [Required]
        public string Venue { get; set; }
        [Required]
        [FutureDate]
        public  string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        public DateTime GetDateTime()
        {

            return DateTime.Parse(string.Format("{0} {1}", Date, Time));

        }
        [Required]
        public byte Genre { get; set; }
        [Required]
        public IEnumerable<Genre> Genres { get; set; }
    }
}