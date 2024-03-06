using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_zdarzenia
{
  internal class Program
  {
    static void Main(string[] args)
    {
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
