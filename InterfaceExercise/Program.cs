using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What type of vehicle do you want to build?");
            string vehicleIn = Console.ReadLine();
            IVehicle Vehicle = VehicleFactory.GetVehicle(vehicleIn);
            Vehicle.Build();
            Console.WriteLine();
            Vehicle.GetInfo();
        

        //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
