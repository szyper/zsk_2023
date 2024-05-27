using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_dziedziczenie.classes
{
  public enum MachineType
  {
    Excavator,
    Crane,
    Bulldozer,
    Loader
  }
  //zarządza grupą maszyn
  internal class MachineSimulator
  {
    private List<Machine> machines = new List<Machine>();

    public void AddMachine(Machine machine)
    {
      machines.Add(machine);
    }

    public void StartAll()
    {
      foreach (var machine in machines)
      {
        machine.Work();
      }
    }

    public void StopAll()
    {
      foreach (var machine in machines)
      {
        machine.Stop();
      }
    }

    public void DisplayAllMachines()
    {
      foreach (var machine in machines)
      {
        Console.WriteLine($"- {machine.Name}");
      }
    }
  }
}
