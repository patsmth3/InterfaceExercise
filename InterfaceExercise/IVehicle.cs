using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        //In your IVehicle
        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */
        
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool AllWheelDrive  { get; set; }

        public void GetInfo();
        
        public void VehicleType();

        public void build();

    }
}