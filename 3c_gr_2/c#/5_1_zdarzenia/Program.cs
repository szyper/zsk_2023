using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_zdarzenia
{
  //definicja delegata
  public delegate void MessageHandler(string message);

  //klasa wydawcy
  public class Publisher
  {
    //deklaracja zdarzenia
    public event MessageHandler MessageEvent;

    //Metoda, która wywołuje zdarzenie
    public void SendMessage(string message)
    {
      //sprawdzenie, czy zdarzenie ma subskrybentów
      if (MessageEvent != null)
      {
        //wywołanie zdarzenia
        MessageEvent(message);
      }
    }
  }

  //klasa subskrybenta
  public class Subscriber
  {
    //metoda obsługi zdarzenia
    public void OnMessageReceived(string message)
    {
      Console.WriteLine("Otrzymałem wiadomość: {0}", message);
    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      //utworzenie obiektów wydawcy i subskrybenta
      Publisher pub = new Publisher();
      Subscriber sub = new Subscriber();

      //subskrypcja zdarzenia
      pub.MessageEvent += sub.OnMessageReceived;

      //wywołanie metody, która wywołuje zdarzenie
      pub.SendMessage("Pierwsza wiadomość");
      pub.SendMessage("Druga wiadomość");
      pub.SendMessage("Trzecia wiadomość");

      //anulowanie subskrypcji zdarzenia
      pub.MessageEvent -= sub.OnMessageReceived;
      pub.SendMessage("Czwarta wiadomość");

      pub.MessageEvent += sub.OnMessageReceived;
      pub.SendMessage("Piąta wiadomość");

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
