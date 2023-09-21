using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public bool isDriveable { get; set; }
        public string HonkNoise { get; set; }

        public void MakeEngineNoise()
            {
            Console.WriteLine(EngineNoise);
            }
        public void MakeHonkNoise()
        { 
            Console.WriteLine(HonkNoise);
        }
        public Car(int year, string make, bool isDrive, string model, string engineNoise, string honkNoise)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            isDriveable = isDrive;
            
        }

    }
}

