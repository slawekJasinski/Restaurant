﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string Title { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
    }
}
