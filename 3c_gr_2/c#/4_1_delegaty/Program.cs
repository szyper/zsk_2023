using System.Numerics;

namespace _4_delegaty
{
  internal class Program
  {
    public delegate int Operation(int x, int y);
    public static int Add(int x, int y)
    {
      return x + y;
    }

    public static int Subtract(int x, int y)
    {
      return x - y;
    }

    public static int Multiply(int x, int y)
    {
      return x * y;
    }

    public static int Divide(int x, int y)
    {
      return x / y;
    }

    public static void DisplayResult(Operation op, int x, int y)
    {
      int result;
      if (op.Method.Name == "Divide" && y == 0)
      {
        Console.WriteLine("Dzielenie przez 0!");
        result = 0;
      }
      else
      {
        result = op(x, y);
        Console.WriteLine("Wynik operacji {0} na liczbach {1} i {2} wynosi {3}", op.Method.Name, x, y, result);
      }
    }

    public static int GetIntFromUser(string prompt)
    {
      Console.Write(prompt);
      int number;
      string? input = Console.ReadLine();

      bool isValid = int.TryParse(input, out number) && number >= 0;

      while (!isValid)
      {
        Console.Write("Nieprawidłowe dane. Podaj liczbę całkowitą nieujemną:");
        input = Console.ReadLine();
        isValid = int.TryParse(input, out number) && number >= 0;
      }
      return number;
    }
    static void Main(string[] args)
    {
      int a = GetIntFromUser("Podaj a:");
      int b = GetIntFromUser("Podaj b:");

      Operation adding = new Operation(Add);
      Operation substracting = new Operation(Subtract);
      Operation multiplying = new Operation(Multiply);
      Operation dividing = new Operation(Divide);

      DisplayResult(adding, a, b);
      DisplayResult(substracting, a, b);
      DisplayResult(multiplying, a, b);
      DisplayResult(dividing, a, b);
    }
  }
}

/*
 * Zadania - delegaty
● Napisz program w języku C#, który używa delegatów do wykonania
operacji arytmetycznych na dwóch liczbach podanych przez
użytkownika.
● Zadeklaruj typ delegata, który przyjmuje i zwraca int, i nazwij go
Operation.

● Zdefiniuj cztery metody statyczne, które realizują operacje dodawania,
odejmowania, mnożenia i dzielenia dwóch liczb, i nazwij je odpowiednio
Add, Subtract, Multiply i Divide.

● Zdefiniuj metodę statyczną, która wyświetla wynik operacji na liczbach, i
nazwij ją DisplayResult. Metoda ta powinna przyjmować jako argumenty
instancję delegata Operation, dwie liczby i wywoływać metodę związaną
z delegatem na tych liczbach. Metoda ta powinna również obsługiwać
wyjątek DivideByZeroException, jeśli wystąpi, i wyświetlać odpowiedni
komunikat o błędzie.

● Zdefiniuj funkcję, która pobiera liczbę całkowitą nieujemną od
użytkownika, i nazwij ją GetIntFromUser. Funkcja ta powinna wyświetlać
podpowiedź dla użytkownika, pobierać dane od użytkownika,
sprawdzać, czy dane są poprawne i nieujemne, i zwracać liczbę. Jeśli
dane są nieprawidłowe, funkcja powinna wyświetlać komunikat o
błędzie i prosić użytkownika o ponowne wprowadzenie danych.

● W metodzie Main, pobierz dwie liczby od użytkownika za pomocą
funkcji GetIntFromUser i zapisz je w zmiennych a i b.

● Utwórz cztery instancje delegata Operation i przypisz im metody Add,
Subtract, Multiply i Divide.

● Wywołaj metodę DisplayResult dla każdej instancji delegata i przekaż jej
zmienne a i b jako argumenty.

● Przetestuj swój program dla różnych danych wejściowych i sprawdź, czy
działa poprawnie.
*/


