using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    public interface ICompany
    {
        //In ICompany
        /*Create 2 members that are specific to each every company
         * regardless of vehicle type
         * Example: public string Logo { get; set; }
         */
        
        public string Logo { get; set; }
        public string Moto { get; set; }

        public void CompanyMoto();

    }
}