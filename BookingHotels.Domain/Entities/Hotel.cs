﻿using System;
using System.Collections.Generic;
using BookingHotels.Domain.Enums;

namespace BookingHotels.Domain.Entities
{
    public class Hotel
    {
        public Guid Id { get; set; }
        public string HotelName { get; set; }
        public HotelStars HotelStars { get; set; }
        // Link to hotel rooms collection
        public virtual List<Room> Rooms { get; set; }
    }
}
