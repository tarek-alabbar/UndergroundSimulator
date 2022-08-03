using System;
using UndergroundSimulator.Model.Entity;
namespace UndergroundSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Station station = new Station();
            station.Name = "Ealing Broadway";
            station.Type = "Underground";
            station.Zone = "3";
            station.IsAccessable = true;
            station.Status = Station.Statuses.Good;
            station.Platforms.AddRange(new List<string>() { "1", "2", "3", "4" });

            //TODO: this is a good example to implement generic list
            station.Connects.AddRange(new List<string>() { "District", "Elizabeth Line", "National Rail" });

            Line line = new Line();
            line.Name = "Central";

            System.Console.WriteLine("Name: {0} \nType: {1} \nZone: {2} \nWheelchair accessible: {3} \nStatus: {4} ", station.Name, station.Type, station.Zone, station.IsAccessable, station.Status);

            foreach (string platform in station.getPlatforms())
            {
                System.Console.WriteLine("Platform {0}", platform);
            }

            foreach (string connect in station.Connects)
            {
                Console.Write(connect + " ");
            }
        }
    }
}