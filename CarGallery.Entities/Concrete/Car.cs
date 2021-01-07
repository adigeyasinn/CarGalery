﻿using CarGallery.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGallery.Entities.Concrete
{
    public class Car:IEntity
    {
       

        public int CarId { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public Car(string model, decimal price)
        {
            Model = model;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Model}" +
                $"{Price}";
        }

    }
}
