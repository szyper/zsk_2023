namespace _6_klasy_abstrakcyjne_interfejsy_delegaty_zdarzenia
{
  public delegate void PerformanceHandler();

  public interface IMusician
  {
    event PerformanceHandler OnPerformance;
    void Play();
    void Compose();
  }

  public abstract class Musician : IMusician
  {
    public string Name { get; set; }
    public event PerformanceHandler OnPerformance;

    public Musician(string name)
    {
      Name = name;
    }

    protected virtual void Perform()
    {
      OnPerformance?.Invoke();
    }

    public virtual void Compose()
    {
      throw new NotImplementedException();
    }

    public virtual void Play()
    {
      throw new NotImplementedException();
    }
  }

  public class Pianist : Musician
  {
    public Pianist(string name) : base(name) { }

    public override void Play()
    {
      Perform();
      Console.WriteLine($"{Name} gra na pianinie");
    }

    public override void Compose()
    {
      Console.WriteLine($"{Name} komponuje muzykę na pianino");
    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
    }
  }
}

/*
 * Zdefiniuj delegata PerformanceHandler, który nie przyjmuje żadnych parametrów i zwraca void.
Dodaj zdarzenie OnPerformance do interfejsu IMusician, używając delegata PerformanceHandler.
Zmodyfikuj klasę abstrakcyjną Musician, aby zawierała metodę wyzwalającą zdarzenie OnPerformance.
Utwórz konkretne klasy Pianist i Guitarist, które dziedziczą po klasie Musician i implementują własne wersje metod Play() i Compose(), a także wyzwalają zdarzenie OnPerformance podczas wykonywania metody Play().
W metodzie Main() zasubskrybuj zdarzenie OnPerformance dla każdego muzyka i dostarcz metodę zwrotną, która wypisze wiadomość na konsoli informującą o występie.
Stwórz listę muzyków różnych typów, wywołaj ich metody i obserwuj działanie zdarzeń.
*/