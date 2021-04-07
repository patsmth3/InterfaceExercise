using System;
namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle
    {
        public string cargo { get; set; }
        public string hatchback { get; set;}
        
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
            Console.WriteLine($"{CompanyBrand}")
        }
    }
}