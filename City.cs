using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        // ----------- Private Properties -------------

        // -------- Public Properties -------------
        public string city { get; set; }
        public string mayor { get; set; }
        public int est { get; set; }

        public List<Building> buildings { get; set; }

        // -------- Constructor -----------
        public City(string nameOfCity)
        {
            city = nameOfCity;
        }

        // ------- METHODS ---------- 

    }

}