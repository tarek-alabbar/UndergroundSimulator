using System;
using System.Collections.Generic;

namespace UndergroundSimulator.Model.Entity
{
    public class Station
    {
        public string Name;
        public string Type;
        public string Zone;
        public bool IsAccessable;
        public enum Statuses { Good, Busy, Closed, Disturbed };
        public Statuses Status;
        public List<string> Platforms = new List<string>();
        public List<string> Connects = new List<string>();

        public string GetName()
        {
            return Name;
        }

        public List<string> getPlatforms()
        {
            return Platforms;
        }
    }
}
