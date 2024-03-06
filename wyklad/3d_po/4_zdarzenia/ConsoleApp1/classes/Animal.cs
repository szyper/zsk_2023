using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
  internal class Animal
  {
    public string Name { get; set; }

    public Animal(string name)
    {
      Name = name;
    }

    public virtual void Speak()
    {
      Console.WriteLine("Nieznany dźwięk");
    }

    public event EventHandler OnSpeak;

    protected virtual void RaiseOnSpeak()
    {
      /*if (OnSpeak != null)
      {
        EventHandler e = new EventHandler(OnSpeak);
      }*/

      if (OnSpeak != null)
      {
        EventArgs e = new EventArgs();
        OnSpeak(this, e);
      }
    }



  }
}
