﻿using System;

namespace Entities
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }
        public bool DestinationPoint { get; set; }
        public bool StartPoint { get; set; }
        public bool NeedsHotel { get; set; }
        public bool NeedsRestaurant { get; set; }
        public string RestaurantType { get; set; }
        public bool NeedsMuseum { get; set; }
        public string MuseumType { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
