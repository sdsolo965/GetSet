using System;

namespace GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add a new car to your collection");
            Console.WriteLine("Please enter a make");
            string userMake = Console.ReadLine();

            Console.WriteLine("Please enter a model");
            string userModel = Console.ReadLine();

            Console.WriteLine("Please enter a year");
            int userYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a license plate");
            string userLicensePlate = Console.ReadLine();

            Car carOne = new Car(userMake, userModel, userYear, userLicensePlate);

            Console.WriteLine($"Thanks! Your car is a {carOne.Year} {carOne.Make} {carOne.Model} with license plate {carOne.LicensPlate}");
        }
    }

    class Car
    {
        public string Make;
        public string Model;
        public int Year;

        //Must be seven chars
        private string _licensePlate;

        //prop (tab, tab) is shortcut to make a new property
        public string LicensPlate
        {
            get { return _licensePlate; }
            set
            {
                if (!(String.IsNullOrWhiteSpace(value)) && value.ToCharArray().Length == 7)
                {
                    _licensePlate = value;
                }
                while (_licensePlate == null)
                {
                    System.Console.WriteLine("Please enter a new License Plate value that is seven characters.");
                    string userInput = Console.ReadLine();
                    if (!(String.IsNullOrWhiteSpace(userInput)) && userInput.ToCharArray().Length == 7)
                    {
                        _licensePlate = userInput;
                    }
                }
            }
        }

        public Car(string make, string model, int year, string licensPlate)
        {
            Make = make;
            Model = model;
            Year = year;
            LicensPlate = licensPlate;
        }
    }
}
