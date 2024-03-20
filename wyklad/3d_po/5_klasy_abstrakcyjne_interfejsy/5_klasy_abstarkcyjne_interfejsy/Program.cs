using System.Diagnostics;

namespace _5_klasy_abstarkcyjne_interfejsy
{

  //definicja zachowań

  /*
  public interface ICar
  {
    void StartEngine();
    void StopEngine();
  }

  public abstract class Car :ICar
  {
    public void StartEngine()
    {
      Console.WriteLine("Uruchomienie silnika");
    }

    public void StopEngine()
    {
      Console.WriteLine("Zatrzymanie silnika");
    }
  }
  */

  //implementacja wielu interfejsów

  /*
  public interface ICar
  {
    void StartEngine();
    void StopEngine();
  }

  public interface IAlarm
  {
    void ActiveAlarm();
  }

  public class PassangerCar : ICar, IAlarm
  {
    public void ActiveAlarm()
    {
      throw new NotImplementedException();
    }

    public void StartEngine()
    {
      throw new NotImplementedException();
    }

    public void StopEngine()
    {
      throw new NotImplementedException();
    }
  }
  */

  //Dziedziczenie stanu
  /*
  public abstract class Car
  {
    protected string registrationNumber;
  }
  */

  //Modyfikatory dostępu
  /*
  public abstract class Car
  {
    public abstract void StartEngine();
    protected abstract void Refuel();
  }
  */

  //pola i właściwości
  /*
  public abstract class Car
  {
    public abstract int NumberofWheels {  get; }
    public string VIN { get; set; }
  }
  */

  //Konstruktory
  /*
  public abstract class Car
  {
    protected string VIN { get; private set; }
    protected Car(string vin)
    {
      vin = vin;
    }
  }
  */

  //metody domyślne
  /*
  public interface ICar
  {
    void StartEngine();
    void StopEngine() => Console.WriteLine("Silnik zatrzymany");
  }
  */

  //wielokrotne dziedziczenie
  public class PassangerCar : ICar, IAlarm
  {

  }

  public interface ICar
  {
  }

  internal interface IAlarm
  {
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
    }
  }
}
