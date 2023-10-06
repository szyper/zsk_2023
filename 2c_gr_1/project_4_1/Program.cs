namespace project_4_1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string message = "imię I NAzwisko"; 
      Console.WriteLine(message);

      string messageUpper = message.ToUpper();
      Console.WriteLine(messageUpper);

      Console.WriteLine(message.Substring(7)); //NAzwisko
      Console.WriteLine(message.Substring(7, 3)); //NAz

      Console.WriteLine(message[0]); //i

      string newMessage = message[0].ToString().ToUpper() + message.Substring(1).ToLower();
      Console.WriteLine(newMessage); //Imię i nazwisko

      string newMessage1 = message.Substring(0,1).ToUpper() + message.Substring(1).ToLower();
      Console.WriteLine(newMessage1); //Imię i nazwisko

      //zakres zmiennej
      Console.WriteLine(int.MinValue); //-2 147 483 648
      Console.WriteLine(int.MaxValue); //2 147 483 647

      Console.WriteLine(char.MaxValue); //wyświetla ?

      string firstName = "Janusz";
      Console.WriteLine(firstName.Length); //6

      string lastName = "Bąk";
      Console.WriteLine(lastName.Length); //3

      Console.WriteLine(lastName[0]); //B

      Console.WriteLine(firstName.Equals(lastName)); //False
      Console.WriteLine("Janusz".Equals("Janusz")); //True
      Console.WriteLine("janusz".Equals("Janusz")); //False

      //###########################################################

      Console.Write("Podaj imię:");
      string? name = Console.ReadLine();

      while (name.Length == 0)
      {
        Console.Write("Podaj imię:");
        name = Console.ReadLine();
      }

      Console.WriteLine("Imię: " + name);

      //###########################################################

      Console.Write("Podaj długość boku kwadratu:");
      float a1 = float.Parse(Console.ReadLine());
      while (a1 <= 0)
      {
        Console.Write("Podaj długość boku kwadratu:");
        a1 = float.Parse(Console.ReadLine());

      }

      Console.WriteLine($"Bok kwadratu wynosi: {a1}, pole: {a1*a1}cm^2");

      //###########################################################
      //pole trójkąta wzorem 
      /*Herona wzór, mat. wzór na obliczanie pola trójkąta S, gdy dane są jego boki a, b, c: , gdzie p = (a + b + c)/2 — połowa obwodu trójkąta.
       */

      Console.Clear();
      double a, b, c;
        
      do
      {
        Console.Write("Podaj a:");
        a = double.Parse(Console.ReadLine());

        Console.Write("Podaj b:");
        b = double.Parse(Console.ReadLine());

        Console.Write("Podaj c:");
        c = double.Parse(Console.ReadLine());
      } while (a + b <= c || a + c <= b || b + c <= a);

      double p = (a + b + c) /2;
      double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
      Console.WriteLine($"Pole trójkąta wynosi: {area:F2}cm^2");




}
}
}