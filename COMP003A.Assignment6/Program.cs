// Author: Jovani Benavides 
// Course: Comp-003A
// Purpose: Object-Oriented programming for week 6

namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintSeparator("vehicle1");
            Vehicle vehicle1 = new Car();
            vehicle1.Brand = "Tesla";   //can acces properties to get/set its value by using this syntax
            vehicle1.Model = "Model X";
            vehicle1.NumberOfWheels = 4;
            vehicle1.GetInfo();

            PrintSeparator("vehicle2");     // if class takes no parameters
            Vehicle vehicle2 = new Car()    // can simplify value assignment like below
            {
                Brand = "Toyota",
                Model = "Supra",
                NumberOfWheels = 4
            };
            vehicle2.GetInfo();
            Console.WriteLine("But you can still access my Properties.");
            Console.WriteLine($"{vehicle2.Brand} {vehicle2.Model} {vehicle2.NumberOfWheels}");

            PrintSeparator("vehicle3"); // if class takes parameters, use syntax below
            Vehicle vehicle3 = new Truck("GMC", "Sierra 1500 AT4", 6, 5.5);
            vehicle3.GetInfo();

            PrintSeparator("vehicle4"); // alternate for class that takes parameters
            Vehicle vehicle4 = new Truck(truckNumberOfWheels: 4, truckBrand: "Ford", truckModel: "F-150 Raptor", sizeOfTruckBed: 5.5);
            vehicle4.GetInfo();

        }

        // Section Title
        /// <summary>
        /// Section Separator
        /// </summary>
        /// <param name="sectionName">String Input for Section title name</param>
        static void PrintSeparator(string sectionName)
        {
            Console.WriteLine("".PadRight(50, '~'));
            Console.WriteLine($"\t\t{sectionName} Section");
            Console.WriteLine("".PadRight(50, '~'));
        }
    }
}