using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Properties_Interfaces_.Property
{
    internal class Car
    {
        public Car(string make, string model, int year, int mileage = 0)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (DateTime.Now.Year > value)
                    this.year=value;
                else
                    throw new ArgumentException("You can't assign year from the future");
            }
        }
        public int Age=>DateTime.Now.Year - this.Year;
         
        public void Drive(int distance)
        {
            if (distance > 0)
            {
                this.Mileage += distance;
                Console.WriteLine($"The vehicle was driven for a distance :{distance} \nCurrent total miles for this car : {Mileage}");
            }
            else
                Console.WriteLine("Distance must be positive");
        }
    }
}
