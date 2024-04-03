namespace _6_1_konstruktory_bledy
{
  internal class Program
  {
    public class Przyklad1
    {
      // Błąd: Konstruktor jest prywatny, co uniemożliwia tworzenie instancji klasy z zewnątrz.
      private Przyklad1() { }
    }

    public class Przyklad2
    {
      // Błąd: Konstruktor nie może mieć typu zwracanego.
      public void Przyklad2() { }
    }

    public class Przyklad3
    {
      // Błąd: Konstruktor ma parametry, więc nie jest to konstruktor domyślny.
      public Przyklad3(int parametr) { }
    }

    public class Przyklad4
    {
      // Błąd: Konstruktor domyślny nie powinien być statyczny.
      public static Przyklad4() { }
    }

    public class Przyklad5
    {
      public string Nazwa { get; set; } = "Domyślna Nazwa";

      public Przyklad5()
      {
        //Błąd: nieprawidłowe użycie składni konstruktora
        get { return Nazwa; }

        //prawidłowe:
        Nazwa = "nowa nazwa";
      }
    }

    public class Przyklad6
    {
      public int Liczba { get; set; } = 10;

      // Błąd: Niepoprawne użycie operatora 'this' do przypisania wartości domyślnej.
      public Przyklad6()
      {
        this.Liczba = this.Liczba;
      }
    }

    public class Przyklad7
    {
      // Błąd: Nie można używać 'ref' ani 'out' w konstruktorze domyślnym.
      public Przyklad7(out int parametr)
      {
        parametr = 5;
      }
    }

    public class Przyklad8
    {
      public static string StatycznaWartosc { get; set; } = "Domyślna Wartość";

      // Błąd: Próba dostępu do statycznej właściwości w konstruktorze niestatycznym.
      public Przyklad8()
      {
        StatycznaWartosc = "Nowa Wartość";
      }
    }

    //rozwiązanie błędu z Przykladem8
    public class Przyklad8_
    {
      public static string StatycznaWartosc { get; set; }

      // Prawidłowy konstruktor statyczny.
      static Przyklad8_()
      {
        StatycznaWartosc = "Nowa Wartość";
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
    }

    
  }
}
