using _14_1_dziedziczenie.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_dziedziczenie
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
      Machine machine = new Machine("M-100");

      Excavator excavator = new Excavator("E-200");
      excavator.Start();
      excavator.Stop("awaria silnika");
      excavator.Work();
      //excavator.Dig();
      */

      MachineSimulator simulator = new MachineSimulator();

      simulator.AddMachine(new Excavator("Koparka E-100"));
      simulator.AddMachine(new Crane("Dźwig D-100"));
      simulator.AddMachine(new Bulldozer("Spychacz B-100"));
      simulator.AddMachine(new Loader("Ładowacz L-100"));

      simulator.StartAll();
      simulator.StopAll();
      simulator.DisplayAllMachines();

      Console.ReadKey();
    }
  }
}