using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle
    {
        public string bedSize { get; set;}
        public string camper { get; set; }
        
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool AllWheelDrive { get; set; }
        public void Vehicle()
        {
            throw new NotImplementedException();
        }

        public bool allWheelDrive  { get; set; }
        
        public string Logo { get; set; }
        public string Moto { get; set; }
        public void CompanyMoto()
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            Console.WriteLine("Cars are nice to drive");
        }

        public void CompanyBrand()
        {
            Console.WriteLine($"{Moto}");
        }
    }
}