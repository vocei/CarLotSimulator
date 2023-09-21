using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            
            var cliffsCar = new Car();
            cliffsCar.Year = 2024;
            cliffsCar.Make = "Ford";
            cliffsCar.isDriveable = false;
            cliffsCar.EngineNoise = "vroom";
            cliffsCar.Model = "Focus";
            cliffsCar.HonkNoise = "beep";

            lot.Cars.Add(cliffsCar);




            var obamaCar = new Car()
            {
                Year = 1969,
                Make = "Audi",
                isDriveable = true,
                Model = "r8",
                EngineNoise = "vroom vroom",
                HonkNoise = "meep meep",
            };

            lot.Cars.Add(obamaCar);

            var truecodersCar = new Car(1900, "Toyota", true, "Camry", ". . .", "AHHHHHHHH");
           
            lot.Cars.Add(truecodersCar);

            cliffsCar.MakeHonkNoise();
            obamaCar.MakeHonkNoise();
            truecodersCar.MakeHonkNoise();

            cliffsCar.MakeEngineNoise();
            obamaCar.MakeEngineNoise();
            truecodersCar.MakeEngineNoise();

            Console.WriteLine($"Number of cars in lot {CarLot.numberOfCars}");

            foreach (var car in lot.Cars) 
            {
                Console.WriteLine($"Make: {car.Make} \nModel: {car.Model} \nYear: {car.Year} \nEngine Noise: {car.EngineNoise} \nHonk Noise: {car.HonkNoise} \nDriveable?: {car.isDriveable}");
            }


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }
    }
}
