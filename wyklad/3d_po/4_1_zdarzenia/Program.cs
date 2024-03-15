using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_zdarzenia
{
    internal class Program
    {
        public delegate void AnimalSound(string sound);

        public class Animal
        {
            public event AnimalSound AnimalSoundEvent;


            public string Name { get; set; }
            public string Spieces { get; set; }
            public int Age { get; set; }

            public Animal(string name, string spieces, int age)
            {
                Name = name;
                Spieces = spieces;
                Age = age;
            }

            public void MakeSound()
            {
                string sound = "";
                switch(Spieces.ToLower())
                {
                    case "dog":
                        sound = "Hou Hou";
                        break;
                    case "cat":
                        sound = "Miau";
                        break;
                    default:
                        sound = "Nieznany dźwięk";
                        break;
                }

                AnimalSoundEvent?.Invoke(sound);

            }
        }
        
            
        static void Main(string[] args)
        {
        }
    }
}
