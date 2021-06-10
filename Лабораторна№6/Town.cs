using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_6
{
    public class TheTown
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
        public string Printing { get; set; }
        public double Warranty { get; set; }
        public double Price { get; set; }
        public bool Wifi { get; set; }
        public bool Color { get; set; }
        
        public TheTown()
        {
        }
        public TheTown(string name, string country, string region,
        string printing, double yearIncome, double square,
        bool hasPort, bool hasAirport)
        {
            Name = name;
            Country = country;
            Type = region;
            Printing = printing;
            Warranty = yearIncome;
            Price = square;
            Wifi = hasPort;
            Color = hasAirport;
        }
    }
}
