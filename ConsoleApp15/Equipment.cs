using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Equipment
    {
        private static int SerialBase = 1000;
        public string Name { get; set; }
        public int SerialNumber { get; set; }
        public string Manufactorer { get; set; }
        public int NumberOfUnits { get; set; }
        public string Category { get; set; }

        public Equipment(string name, string manufactorer, int numberOfUnits, string category)
        {
            Name = name;
            SerialNumber = CalculatedSerialNumber();
            Manufactorer = manufactorer;
            NumberOfUnits = numberOfUnits;
            Category = category;
        }
        public int CalculatedSerialNumber()
        {
            SerialBase++;
            return SerialBase;
        }
        public override string ToString() {
            return $"{Name}  {SerialNumber} {Manufactorer} {NumberOfUnits} {Category}";
        }
    }
}
