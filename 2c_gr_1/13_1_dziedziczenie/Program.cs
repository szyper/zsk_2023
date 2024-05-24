using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_dziedziczenie
{
  internal class Program
  {
    public enum FuelType
    {
      Petrol,
      Diesel,
      Electric
    }

    public class Vehicle
    {
      public string Brand { get; set; }
      public string Model { get; set; }
      public double Fuel { get; protected set; } //poziom paliwa
      public FuelType FuelType { get; protected set; } //typ paliwa
      public ushort Speed { get; set; } //aktualna prędkość pojazdu
      public virtual void StartEngine()
      {
        Console.WriteLine("\nSilnik uruchomiony");
      }
      public virtual void StopEngine()
      {
        Console.WriteLine("\nSilnik zatrzymany");
      }
      public void Refuel(double amount)
      {
        Fuel += amount;
        Console.WriteLine($"\nZatankowano {amount} litrów paliwa w pojeździe");
      }
      public void UpdateSpeed(ushort newSpeed)
      {
        Speed = newSpeed;
      }
    }

    public class Car : Vehicle
    {
      public byte NumberOfDoors { get; set; } //liczba drzwi
      public byte CurrentGear { get; private set; } //aktualny bieg
      public int MaxGear { get; set; } //maksymalny bieg
      public bool IsAutomatic { get; set; } //czy skrzynia jest automatyczna
      public override void StartEngine()
      {
        Console.WriteLine("\nSilnik samochodu uruchomiony");
      }
      public override void StopEngine()
      {
        Console.WriteLine("\nSilnik samochodu zatrzymany");
      }

      //metoda do zmiany biegów
      public void ChangeGear(byte gear)
      {
        if (IsAutomatic)
        {
          Console.WriteLine("\nTen samochód ma automatyczną skrzynię biegów");
        }
        else
        {
          if (gear < 0 || gear > MaxGear)
          {
            Console.WriteLine("\nNieprawidłowy bieg");
          }
          else
          {
            CurrentGear = gear;
            Console.WriteLine($"\nZmiana biegu na {gear}");
          }
        }
      }
    }
    static void Main(string[] args)
    {
      Vehicle vehicle = new Vehicle();
      vehicle.Brand = "Lamborghini";
      Console.WriteLine($"Marka: {vehicle.Brand}");
      vehicle.StartEngine();

      Car car = new Car();
      car.Brand = "Fiat";
      Console.WriteLine($"Marka: {car.Brand}");
      car.StartEngine();

      Console.ReadKey();
    }
  }
}
