// Project - Program04
// Program04.cs

using System;
using static System.Console;

namespace Program04
{
    class Automobile
    {
        // REQUIREMENT 2.d
        // member variables
        private string make;
        private string model;
        private string color;
        private double speed = 60.0;

        // REQUIREMENT 2.a
        //PDDC
        public Automobile()
        {
            WriteLine("\na. In Automobile Programmer-Defined Default Constructor\n");
        }
        //PDC
        public Automobile(string make, string model, string color, double speed)
        {
            WriteLine("\na. In Automobile Programmer-Defined Constructor\n");
        }

        // REQUIREMENT 2.b
        // getters
        public string GetMake()
        {
            return make;
        }
        public string GetModel()
        {
            return model;
        }
        public string GetColor()
        {
            return color;
        }
        public double GetSpeed()
        {
            return speed;
        }
        // REQUIREMENT 2.b
        // setters
        public void SetMake(string make)
        {
            this.make = make;
        }
        public void SetModel(string model)
        {
            this.model = model;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void SetSpeed(double speed)
        {
            this.speed = speed;
        }

        // REQUIREMENT 2.c
        // increase speed
        public double IncreaseSpeed(double speed, double change)
        {
            speed = speed+change;
            SetSpeed(speed);
            return speed;
        }

        // decrease speed
        public double DecreaseSpeed(double speed, double change)
        {
            speed = speed-change;
            SetSpeed(speed);
            return speed;
        }

        public void ShowSpeed(int carNumber)
        {
            WriteLine("c. Automobile {0}'s speed is: {1}", carNumber, GetSpeed());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /******************************************************************************************************/
            // Welcome Message
            PrintRequirement(1);
            WriteLine("\nWelcome to Assignment 04 - <Dustin Sherer>");

            /******************************************************************************************************/
            // Automobile
            /******************************************************************************************************/
            PrintRequirement(2);
            WriteLine("\nRequirements for first round of a, b, c, and d, are designated in the comments of the Automobile class.");

            int maxNumofCars = 99;
            int numofcars;

            Write("\na. How many automobiles would you like to create? : ");
            int.TryParse(ReadLine(), out numofcars);

            //create the automobile array
            Automobile[] autoArray = new Automobile[maxNumofCars];

            for (int i = 0; i < numofcars; ++i)
            {
                //initialize each element (object) of the array before use
                autoArray[i] = new Automobile();

                // make
                Write("b. Enter the automobile " + (i + 1) + " make and press ENTER:  ");
                autoArray[i].SetMake(ReadLine());
                // model
                Write("b. Enter the automobile " + (i + 1) + " model and press ENTER:  ");
                autoArray[i].SetModel(ReadLine());
                // color
                Write("b. Enter the automobile " + (i + 1) + " color and press ENTER:  ");
                autoArray[i].SetColor(ReadLine());
                // print properties
                WriteLine("\nb. Automobile " + (i + 1) + "'s make is {0}", autoArray[i].GetMake());
                WriteLine("b. Automobile " + (i + 1) + "'s model is {0}", autoArray[i].GetModel());
                WriteLine("b. Automobile " + (i + 1) + "'s color is {0}", autoArray[i].GetColor());
                WriteLine("b. Automobile " + (i + 1) + "'s default speed is {0}", autoArray[i].GetSpeed());

                // ask for type of speed change
                char wantToChngSpeed;
                char speedChangeType;
                double speedChangeAmount;

                Write("\nc. Would you like to change the speed? (y/n)");
                wantToChngSpeed = ReadLine()[0];
                if (wantToChngSpeed == 'y')
                {
                    Write("\nc. Would you prefer to (i)ncrease or (d)ecrease the speed? (i/d)");
                    speedChangeType = ReadLine()[0];
                    Write("\nc. By how much? Enter amount: ");
                    speedChangeAmount = Convert.ToDouble(ReadLine());

                    // change speed
                    if (speedChangeType.Equals('i'))
                    {
                        autoArray[i].IncreaseSpeed(autoArray[i].GetSpeed(), speedChangeAmount);
                    }
                    else if (speedChangeType.Equals('d'))
                    {
                        autoArray[i].DecreaseSpeed(autoArray[i].GetSpeed(), speedChangeAmount);
                    }
                    else
                    {
                        // no change
                        WriteLine("\nSpeed will stay the same.");
                    }
                }
                autoArray[i].ShowSpeed(i+1);
            }
            /******************************************************************************************************/
            // Restaurant
            /******************************************************************************************************/
            PrintRequirement(3);
            WriteLine("\nRequirements for a, b.i, b.ii, b.iii, and b.iv are in the comments of the Restaurant class.");

            Restaurant jackAllens = new Restaurant("Austin, TX", "Jack Gilmore", "Southwestern", 3);
            Restaurant otoko = new Restaurant("Austin, TX", "Chef Yoshi", "Japanese", 4);

            WriteLine(jackAllens.RestaurantProperties());
            WriteLine(otoko.RestaurantProperties());

            /******************************************************************************************************/
            // Painting
            /******************************************************************************************************/
            PrintRequirement(4);
            WriteLine("\nRequirements for first round of a and b.i through b.v are designated in the comments of the Paint class.");

            int maxNumofPaint = 99;
            int numofpaints;

            Write("\na. How many paintings would you like to create? : ");
            int.TryParse(Console.ReadLine(), out numofpaints);

            //create the automobile array
            Painting[] paintArray = new Painting[maxNumofPaint];

            for (int i = 0; i < numofpaints; ++i)
            {
                paintArray[i] = new Painting();

                int year;
                double price;

                // artist
                Write("b. Enter the painting " + (i + 1) + "'s artist and press ENTER:  ");
                paintArray[i].Artist = ReadLine();

                // genre
                Write("b. Enter the painting " + (i + 1) + "'s genre and press ENTER:  ");
                paintArray[i].Genre = ReadLine();

                // country
                Write("b. Enter the painting " + (i + 1) + "'s country and press ENTER:  ");
                paintArray[i].Country = ReadLine();

                // year
                Write("b. Enter the painting " + (i + 1) + "'s year and press ENTER:  ");
                int.TryParse(ReadLine(), out year);
                paintArray[i].Year = year;

                // wholesale price
                Write("b. Enter the painting " + (i + 1) + "'s wholesale price and press ENTER:  ");
                double.TryParse(ReadLine(), out price);
                paintArray[i].wholesalePrice = price;

                // print properties
                WriteLine("\nb. painting " + (i + 1) + "'s artist is {0}", paintArray[i].Artist);
                WriteLine("b. painting " + (i + 1) + "'s genre is {0}", paintArray[i].Genre);
                WriteLine("b. painting " + (i + 1) + "'s country is {0}", paintArray[i].Country);
                WriteLine("b. painting " + (i + 1) + "'s year is {0}", paintArray[i].Year);
                WriteLine("b. painting " + (i + 1) + "'s wholesale price is {0}", paintArray[i].wholesalePrice);
                WriteLine("\nc. painting " + (i + 1) + "'s retail price would be {0}", paintArray[i].CalcRetail());
            }

            /******************************************************************************************************/
            // Thank you Message
            /******************************************************************************************************/
            PrintRequirement(5);
            WriteLine("\nThank you for running Program04.");

            /******************************************************************************************************/
            // Experience
            /******************************************************************************************************/
            PrintRequirement(6);
            WriteLine("\nMy experience with Program04 was satisfying. I had just completed a C++ project utilizing constructors last week, and I enjoyed getting the experience/practice implementing them in C#, particularly the auto-implementations.");

            /******************************************************************************************************/

            ForegroundColor = ConsoleColor.White;
            WriteLine("\nPress any key to proceed.");
            ReadKey(true);
        }

        static void PrintRequirement(int reqNum)
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"\nRequiremenet {reqNum}");
            ForegroundColor = ConsoleColor.White;
        }
    }
}
