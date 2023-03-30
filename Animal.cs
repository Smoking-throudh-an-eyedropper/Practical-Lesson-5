using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lesson_5
{
    internal class Animal: InterfaceAnimal
    {
        private string Name;
        private uint Age;
        private double Height;
        private double Weight;
        private string Noise;
        public Animal(string name, uint age, double height, double weight)
        {
            if (name == null)
                throw new NullReferenceException("name");
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
    }
        void Read()
        {
            Console.WriteLine("Укажите имя вашего животного:");
            Name = Convert.ToString(Console.Read());
            Console.WriteLine("Укажите возраст вашего животного:");
            Age = Convert.ToUInt32(Console.Read());
            Console.WriteLine("Укажите рост вашего животного:");
            Height = Convert.ToDouble(Console.Read());
            Console.WriteLine("Укажите вес вашего животного:");
            Weight = Convert.ToDouble(Console.Read());
        }
        void Display()
        {
            Console.WriteLine("Animall");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Age:{Age}");
            Console.WriteLine($"Height:{Height}");
            Console.WriteLine($"Weight:{Weight}");
        }
        public string NoiseYourAnimal (Animal animal)
        {
            if (animal == null)
                throw new NullReferenceException("animal");
            animal.Noise = Convert.ToString(Console.ReadLine());
            return animal.Noise;
        }
        void InterfaceAnimal.OpenTheFucker()
        {
            Console.WriteLine($"Ваше животное будет делать {NoiseYourAnimal(new Animal(Name, Age, Height, Weight))}");
            Console.WriteLine($"{Noise}{Noise}{Noise}{Noise}{Noise}{Noise}{Noise}{Noise}{Noise}{Noise}{Noise}{Noise}...");
        }
    }
}
