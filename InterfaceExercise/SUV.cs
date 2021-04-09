using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle
    {
        public string cargo { get; set; }
        public string hatchback { get; set;}
        
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool AllWheelDrive { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"This is a {Year} {Make} {Model}.");
            Console.WriteLine(GetAllWheelDrive());
        }
        public void VehicleType()
        {
            Year = year;
            Make = make;
            Model = model;
            AllWheelDrive= allWheelDrive;
            
        }
        
        private string GetAllWheelDrive()
        {
            return AllWheelDrive ? "It has all wheel drive." : "It doesn't have all wheel drive.";
        }
     
        public bool allWheelDrive  { get; set; }
        
        public string Logo { get; set; }
        public string Moto { get; set; }
        public void CompanyMoto()
        {
            throw new NotImplementedException();
        }

        public string Brand { get; set; }

        public void Drive()
        {
            Console.WriteLine("Cars are nice to drive");
        }

        public void CompanyBrand()
        {
            Console.WriteLine($"{CompanyBrand}")
        }
    }
}