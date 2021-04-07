using System;
using System.Collections;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public string HasTrunk { get; set; }
        public string Has4Door { get; set; }
            
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool allWheelDrive  { get; set; }
        
        public string Logo { get; set; }
        public string Brand { get; set; }

        public void Drive()
        {
            Console.WriteLine("Cars are nice to drive");
        }

        public void CompanyBrand()
        {
            Console.WriteLine($"{CompanyBrand}");
        }
    }
}