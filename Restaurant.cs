// Project - Program04
// Restaurant.cs

using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Program04
{
    // REQUIREMENT 3
    class Restaurant
    {
        private string city;
        private string chef;
        private string cuisine;
        private int diamondRating;

        // REQUIREMENT 3.a
        public Restaurant()
        {
            WriteLine("a. In Restaurant Programmer-Defined Default Constructor\n");
        }
        public Restaurant(string city, string chef, string cuisine, int diamondRating)
        {
            this.city = city;
            this.chef = chef;
            this.cuisine = cuisine;
            this.diamondRating = diamondRating;

            WriteLine("a. In Restaurant Programmer-Defined Constructor\n");
        }
        // REQUIREMENT 3.b.i
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        // REQUIREMENT 3.b.ii
        public string Chef
        {
            get
            {
                return chef;
            }
            set
            {
                chef = value;
            }
        }
        // REQUIREMENT 3.b.iii
        public string Cuisine
        {
            get
            {
                return cuisine;
            }
            set
            {
                cuisine = value;
            }
        }
        // REQUIREMENT 3.b.iv
        public int AAADiamondRating
        {
            get
            {
                return diamondRating;
            }
            set
            {
                diamondRating = (value >= 1 && value <= 5) ? value : diamondRating;
            }
        }
        // REQUIREMENT 3.c
        public string RestaurantProperties(/*string city, string chef, string cuisine, int diamondRating*/)
        {
            string rProperties;
            rProperties = "c. Restaurant properties: city: " + city + "\n\t\t\t  chef: " + chef + "\n\t\t\t  cuisine: " + cuisine + "\n\t\t\t  AAA-Diamond-Rating: " + diamondRating + "\n";

            return rProperties;
        }
    }
}
