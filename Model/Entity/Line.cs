using System;
using System.Collections.Generic;

namespace UndergroundSimulator.Model.Entity
{
    public class Line
    {
        public string Name;
        public List<Station> stations = new List<Station>();

        public string GetName()
        {
            return Name;
        }

        public List<Station> GetStations()
        {
            return stations;
        }
    }
}