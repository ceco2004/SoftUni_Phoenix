﻿using _02._Cars.Models;
using _02._Cars.Models.Interfaces;
using System;

namespace _02._Cars
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
            

        }
    }
}
