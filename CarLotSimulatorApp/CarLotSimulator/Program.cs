using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            Car car1 = new Car();
            Console.WriteLine(CarLot.numberOfCars)
            Car car2 = new Car();
            Car car3 = new Car();
            //Set the properties for each of the cars
            //Call each of the methods for each car
            car1.Make = "Toyota";
            car1.Year = 1999;
            car1.IsDriveable = true;
            car1.Name = "tony";
            car1.EngineNoise = "humm";
            car1.HonkNoise = "honk";

            car2.Make = "Sienna";
            car2.Year = 2000;
            car2.IsDriveable = false;
            car2.Name = "two";
            car2.EngineNoise = "haha";
            car2.HonkNoise = "honkhonk";

            car3.Make = "Benz";
            car3.Year = 2022;
            car3.IsDriveable = true;
            car3.Name = "black";
            car3.EngineNoise = "hey";
            car3.HonkNoise = "hoho";
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            CarLot lot = new CarLot();
            lot.Carlist.Add(car1);
            lot.Carlist.Add(car2);
            lot.Carlist.Add(car3);
            foreach(var car in lot.Carlist)
            {
                Console.WriteLine(car.Name+car.Make+car.Year);
            }
        }
    }
}
