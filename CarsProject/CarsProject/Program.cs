using System;

namespace CarsProject
{
    internal class Program
    {
        List<Car> cars = new List<Car>();
        static void Main(string[] args)
        {
            //main menu
            //prompt for user input and show menu until exit
            string input = "";
            while(input != "4")
            {
                Console.WriteLine(" Welcome to Jeremy's Car Dealership, where you credit goes to die!");
                Console.WriteLine(" 1. Add a new car");
                Console.WriteLine(" 2. Sell a current car");
                Console.WriteLine(" 3. List all cars");
                input = Console.ReadLine();

            }
        }
        public void AddCar()
        {
            Console.WriteLine("Enter the year of the vehicle:");
            Car car = new Car();
            int year = int.Parse(Console.ReadLine());
            car.year = year;
            Console.WriteLine("Enter the make of the vehicle:");
            string make = Console.ReadLine();
            car.make = make;
            Console.WriteLine("Enter the model of the vehicle:");
            string model = Console.ReadLine();
            car.model = model;
            Console.WriteLine("Enter the number of doors on the vehicle:");
            int numberOfDoors = int.Parse(Console.ReadLine());
            car.numberOfDoors = numberOfDoors;
            Console.WriteLine("Enter the price of the vehicle:");
            double price = double.Parse(Console.ReadLine());
            car.price = price;
            cars.Add(car);
            Console.WriteLine("Your car is a: " + car.year.ToString() + " " + car.make + " " + car.model);
        }
        public void DeleteCar()
        {

        }
        public void ListCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car.year.ToString() + " " + car.make + " " + car.model + " " + car.price.ToString());
            }
        }
    }
}