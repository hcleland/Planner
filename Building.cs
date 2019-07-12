using System;

namespace Planner
{
    public class Building

    {
        // Private Fields (fields don't have get & set) -------------
        // private string _designer;
        // private DateTime _dateConstructed;
        // private string _address;
        // private string _owner;

        // ----------- Private Properties -------------
        private string _designer { get; set; }

        private DateTime _dateConstructed { get; set; }

        private string _owner { get; set; }

        // -------- Public Properties -------------
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public string address { get; set; }
        public double Volume
        {
            get
            {
                return Width * Height * (3 * Stories);
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
        }


        // -------- Constructor -----------
        public Building(string address, string designer)
        {
            this.address = address;
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
            Console.WriteLine($"{address}");
            Console.WriteLine("------------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
            Console.WriteLine(" ");
        }

    }

}