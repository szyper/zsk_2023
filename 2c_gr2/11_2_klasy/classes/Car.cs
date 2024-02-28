using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_parking.classes
{
    internal class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public ushort Year { get; private set; }
        public Color Color { get; private set; }

        public void ShowInformation()
        {
            Console.WriteLine($"To jest {Brand} {Model} z {Year}, kolor: {Color}.");
        }
    }
}
