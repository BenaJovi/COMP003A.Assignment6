using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Abstracts describe a contract but do not give a full implementation of the contract.
    /// </summary>
    abstract class Vehicle : IVehicle
    {
        /* Fields Section */
        // note: in almost all other languages, usually pair field with property
        private string _brand;
        private string _model;
        private int _numberOfWheels;

        /* Constructors Section */
        /// <summary>
        /// default constructor
        /// </summary>
        public Vehicle() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="brand">String input - brand name</param>
        /// <param name="model">String input - model name</param>
        /// <param name="numberOfWheels">Integer input - Number of Wheels</param>
        public Vehicle(string brand, string model, int numberOfWheels)
        {
            Brand = brand;
            Model = model;
            NumberOfWheels = numberOfWheels;
        }

        /* Properties Section */
        /// <summary>
        /// Retrieve/Store Brand info
        /// </summary>
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        /// <summary>
        /// Retrieve/Store Model info
        /// </summary>
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        /// <summary>
        /// Retrieve/Store Number of Wheels info
        /// </summary>
        public int NumberOfWheels
        {
            get { return _numberOfWheels; }
            set { _numberOfWheels = value; }
        }

        /* Methods Section */
        /// <summary>
        /// rints the Brand, Model, and Number of Wheels info
        /// </summary>
        public virtual void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        }


    }
}
