﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double GRAMS = 250;
        private const double CALORIES = 1000;
        private const decimal CAKE_PRICE = (decimal)5;
        public Cake(string name) : base(name, CAKE_PRICE, GRAMS, CALORIES)
        {
        }

    }
}
