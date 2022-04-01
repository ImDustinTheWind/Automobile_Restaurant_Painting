// Project - Program04
// Painting.cs

using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Program04
{
    class Painting
    {
        // REQUIREMENT 4.a using a Default Constructor (hidden)

        // REQUIREMENT 4.b.i
        public string Artist { get; set; }
        // REQUIREMENT 4.b.ii
        public string Genre { get; set; }
        // REQUIREMENT 4.b.iii
        public string Country { get; set; }
        // REQUIREMENT 4.b.iv
        public int Year { get; set; }
        // REQUIREMENT 4.b.v
        public double wholesalePrice { get; set; }

        public double CalcRetail()
        {
            double retailPrice;
            double commission;
            double tax;
            double duty;

            commission = this.wholesalePrice * .4;
            tax = this.wholesalePrice *  .0875;
            duty = this.wholesalePrice * .2;

            WriteLine("\nc. retailPrice = this.wholesalePrice + commission + tax + duty;");

            // REQUIREMENT 4.c
            retailPrice = this.wholesalePrice + commission + tax + duty;
            return retailPrice;
        }

    }
}
