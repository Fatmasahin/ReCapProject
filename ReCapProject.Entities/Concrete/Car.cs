﻿using System;
using ReCapProject.Core.Entities;

namespace ReCapProject.Entities.Concrete
{
    public class Car:IEntity
    {
        // Id, BrandId, ColorId, ModelYear, DailyPrice, Description
        public int ID { get; set; }
        public int BrandId { get; set; }
		public string Name { get; set; }
		public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}

