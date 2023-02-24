using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    internal class Car : Vehicle
    {
        /* Constructors Section */
        //By default, a class has a constructor that has no parameters

        /* Methods Section */
        /// <summary>
        /// Overrides the base Vehicle's definition for GetInfo()
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Car)}");
            Console.WriteLine("I don't want to disclose my information.");
        }
    }
}