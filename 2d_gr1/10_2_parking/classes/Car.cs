using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_parking.classes
{
    enum Color
    {
        Czerwony,
        Zielony,
        Niebieski,
        Czarny,
        Biały
    }
    internal class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public ushort Year { get; private set; }
        public Color Color { get; private set; }

        public void ShowInformation()
        {
            Console.WriteLine($"To jest {Brand} {Model} z {Year}, kolor: {Color}");
        }

        public void SetBrand(string brand)
        {
            Brand = brand;
        }
        public void SetModel(string model)
        {
            Model = model;
        }
        public void SetYear(ushort year)
        {
            Year = year;
        }
        public void SetColor(Color color)
        {
            Color = color;
        }
    }
}