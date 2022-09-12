using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public string Make { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
        public MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }


        //Now that the Car class is created we can instanciate 3 new cars

        //Set the properties for each of the cars

        //Call each of the methods for each car

        //*************BONUS*************//

        // Set the properties utilizing the 3 different ways we learned about, one way for each car

        //*************BONUS X 2*************//

        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    }
    public class CarLot{
        public  List <Car> Carlist { get; set; } = new List<Car> ();

        }
}
