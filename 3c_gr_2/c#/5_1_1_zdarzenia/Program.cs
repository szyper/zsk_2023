using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_1_zdarzenia
{
  //definicja delegata
  public delegate void MessageHandler(string message, int priority);

  //klasa wykonawcy
  public class Publisher
  {
    //deklaracja zdarzenia
    public event MessageHandler MessageEvent;

    //metoda, która wywołuje zdarzenie
    public void SendMessage(string message, int priority)
    {
      //sprawdzenie, czy zdarzenie ma subskrybentów
      if (MessageEvent != null)
      {
        //wywołanie zdarzenia
        MessageEvent(message, priority);
      }
    }
  }

  public class Subscriber
  {
    public int Threshold { get; set; }
    public string Name { get; set; }
    public Subscriber(int threshold, string name)
    {
      Threshold = threshold;
      Name = name;
    }

    //metoda obsługi zdarzenia
    public void OnMessageReceived(string message, int priority)
    {
      if (priority <= Threshold)
      {
        Console.WriteLine("{0} otrzymał wiadomość: {1} o priorytecie: {2}", Name, message, priority);
      }
      else
      {
        Console.WriteLine("{0} nie otrzymał wiadomości o priorytecie: {1}", Name, priority);
      }
    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      //utworzenie obiektów wydawcy i subskrybenta
      Publisher pub = new Publisher();
      Subscriber sub1 = new Subscriber(3, "Subskrybent 1");
      Subscriber sub2 = new Subscriber(4, "Subskrybent 2");

      //subskrypcja zdarzenia
      pub.MessageEvent += sub1.OnMessageReceived;

      //wywołanie metody, która wywołuje zdarzenie
      pub.SendMessage("Pierwsza wiadomość", 3);

      pub.MessageEvent += sub2.OnMessageReceived;
      pub.SendMessage("Druga wiadomość", 3);
      pub.SendMessage("Trzecia wiadomość", 3);
      pub.SendMessage("Czwarta wiadomość", 4);
      pub.SendMessage("Piąta wiadomość", 5);

      pub.MessageEvent -= sub1.OnMessageReceived;
      pub.SendMessage("Szósta wiadomość", 1);

      Console.ReadKey();
    }
  }
}

/*
 * Zdefiniuj delegat MessageHandler, który przyjmuje string i zwraca void.
o Zdefiniuj klasę Publisher z polem MessageEvent typu MessageHandler,
zadeklarowanym jako event.
o Zdefiniuj metodę SendMessage w klasie Publisher, która przyjmuje string i zwraca
void. Metoda ta ma wywoływać zdarzenie MessageEvent, jeśli ma subskrybentów.
*/

/*
 * Zdefiniuj klasę Subscriber z metodą OnMessageReceived, która przyjmuje string i
zwraca void. Metoda ta ma wypisywać na konsolę wiadomość otrzymaną od
wydawcy.
o Zdefiniuj klasę Program z metodą Main, która jest punktem wejścia programu.
o W metodzie Main utwórz obiekty klasy Publisher i klasy Subscriber.
o Zasubskrybuj zdarzenie MessageEvent za pomocą metody OnMessageReceived.
o Wywołaj metodę SendMessage kilka razy z różnymi parametrami i sprawdź, czy
subskrybent otrzymuje wiadomości.
o Anuluj subskrypcję zdarzenia i wywołaj metodę SendMessage ponownie. Sprawdź,
czy subskrybent nadal otrzymuje wiadomości
*/