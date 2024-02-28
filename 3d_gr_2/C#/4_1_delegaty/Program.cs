using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_delegaty
{
    delegate bool Logic(bool a, bool b);
    internal class Program
    {
        static bool And(bool a, bool b)
        {
            return a && b;
        }

        static bool Or(bool a, bool b)
        {
            return a || b;
        }

        static bool Xor(bool a, bool b)
        {
            return a ^ b;
        }

        static bool Not(bool a, bool b)
        {
            return !a;
        }

        static void DisplayResult(Logic logic, bool a, bool b)
        {
            try
            {
                bool result = logic(a, b);
                Console.WriteLine($"Rezultat {logic.Method.Name} {a}, {b} wynosi {result}");
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static bool GetBoolFromUser()
        {
            while(true)
            {
                Console.Write("Wprowadź wartość boolowską (true lub false):");
                string input = Console.ReadLine();
                bool value;
                if (bool.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowe dane. Wprowadź wartość boolowską");
                }
            }
        }

        static void Main(string[] args)
        {
            bool x = GetBoolFromUser();
            bool y = GetBoolFromUser();

            Logic and = new Logic(And);
            Logic or = new Logic(Or);
            Logic xor = new Logic(Xor);
            Logic not = new Logic(Not);

            DisplayResult(and, x, y);
            DisplayResult(or, x, y);
            DisplayResult(xor, x, y);
            DisplayResult(not, x, y);

            Console.ReadKey();
        }
    }
}

/*
 * Napisz program w języku C#, który używa delegatów do wykonania operacji
logicznych na dwóch wartościach boolowskich podanych przez użytkownika.
● Zadeklaruj typ delegata, który przyjmuje i zwraca bool, i nazwij go Logic.
● Zdefiniuj cztery metody statyczne, które realizują operacje logiczne
AND, OR, XOR i NOT na dwóch wartościach boolowskich, i nazwij je
odpowiednio And, Or, Xor i Not.
● Zdefiniuj metodę statyczną, która wyświetla wynik operacji na
wartościach boolowskich, i nazwij ją DisplayResult. Metoda ta powinna
przyjmować jako argumenty instancję delegata Logic, dwie wartości
boolowskie i wywoływać metodę związaną z delegatem na tych
wartościach. Metoda ta powinna również obsługiwać wyjątek
ArgumentNullException, jeśli wystąpi, i wyświetlać odpowiedni
komunikat o błędzie.
● Zdefiniuj funkcję, która pobiera wartość boolowską od użytkownika, i
nazwij ją GetBoolFromUser. Funkcja ta powinna wyświetlać podpowiedź
dla użytkownika, pobierać dane od użytkownika, sprawdzać, czy dane są
poprawne i boolowskie, i zwracać wartość. Jeśli dane są nieprawidłowe,
funkcja powinna wyświetlać komunikat o błędzie i prosić użytkownika o
ponowne wprowadzenie danych.
● W metodzie Main, pobierz dwie wartości boolowskie od użytkownika za
pomocą funkcji GetBoolFromUser i zapisz je w zmiennych x i y.
● Utwórz cztery instancje delegata Logic i przypisz im metody And, Or,
Xor i Not.
● Wywołaj metodę DisplayResult dla każdej instancji delegata i przekaż jej
zmienne x i y jako argumenty.
● Przetestuj swój program dla różnych danych wejściowych i sprawdź, czy
działa poprawnie.
*/
