using System;

namespace Planner
{
    public class Building
    {
        // ----------- Private Properties -------------
        private string _designer { get; set; }

        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        // -------- Public Properties -------------
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Volume
        {
            get
            {
                return Width * Height * (3 * Stories);
            }
        }
        // -------- Constructor -----------
        public Building(string address, string designer)
        {
            _address = address;
            _designer = designer;
        }

        // ------- METHODS ---------- 
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
            // Console.WriteLine($"{_dateConstructed}");
        }

        public void Purchase(string nameOfBuyer)
        {
            _owner = nameOfBuyer;
            Console.WriteLine($"{_address}");
            Console.WriteLine("------------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
            Console.WriteLine(" ");
        }

    }

}