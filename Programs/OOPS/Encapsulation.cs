using System;

namespace OOPS
{
    class Encapsulation
    {
        private string manufacturer;
        private string operating_system;
        public string model;
        private int cost;

        // Constructor to set properties/characteristics of object
        Encapsulation(string manufac, string operatSys, string mod, int cst)
        {
            this.manufacturer = manufac;
            this.operating_system = operatSys;
            this.model = mod;
            this.cost = cst;
        }

        // Method to get access Model property of Object
        public string getModel()
        {
            return this.model;
        }

        public string getManufacturer()
        {
            return this.manufacturer;
        }

        public int getcost()
        {
            return this.cost;
        }

        public string getOperatingSystem()
        {
            return this.operating_system;
        }

        public static void Main()
        {
            Encapsulation en = new Encapsulation("Microsoft", "Windows", "2007", 500);

            Console.WriteLine("Manufacturer: " + en.getManufacturer());
            Console.WriteLine("OS: " + en.getOperatingSystem());
            Console.WriteLine("Model: " + en.getModel());
            Console.WriteLine("Cost: " + en.getcost());

            Console.ReadKey();
        }
    }
}