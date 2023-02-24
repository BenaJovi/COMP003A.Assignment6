using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Truck extends the Vehicle Class
    /// </summary>
    internal class Truck : Vehicle
    {
        /* Fields Section */
        private double _sizeOfTruckBed;

        /* Constructors Section */
        /// <summary>
        /// Constructor that take 4 parameters: truckBrand truckModel truckNumberOfWheels and sizeOfTruckBed
        /// it reuses the base class (Vehicle)'s constructor that takes 3 parameters: brand model numberOfWheels
        /// </summary>
        /// <param name="truckBrand">String input - truckBrand</param>
        /// <param name="truckModel">String input - truckModel</param>
        /// <param name="truckNumberOfWheels">Integer input - truckNumberOfWheels</param>
        /// <param name="sizeOfTruckBed">double Input - sizeOfTruckBed</param>
        /// <param name=""></param>
        public Truck(string truckBrand, string truckModel, int truckNumberOfWheels, double sizeOfTruckBed) : base(truckBrand, truckModel, truckNumberOfWheels)
        {
            SizeOfTruckBed = sizeOfTruckBed;
        }

        /* Properties Section */
        public double SizeOfTruckBed
        {
            get { return _sizeOfTruckBed; }
            set { _sizeOfTruckBed = value; }
        }

        /* Methods Section */
        /// <summary>
        /// Overried base vehicle's definition of GetInfo()
        /// Calls the base Vehicle GetInfo() buts adds on it
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Truck)}.");
            base.GetInfo();
            Console.WriteLine($"I also have a {SizeOfTruckBed} ft. truck bed");
        }
    }
}