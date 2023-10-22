﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking_2pillars.ViewModels
{
    public class BookingInfo
    {
        public int MovieID { get; set; }
        public int ScheduledMovieID { get; set; }
        public List<string> SelectedSeats { get; set; }
        public decimal TotalPrice { get; set; }
        public int SeatID { get; set; }
    }
}
