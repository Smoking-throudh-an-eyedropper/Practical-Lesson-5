using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lesson_5
{
    internal class Dog: Animal
    {
        private string Devotion;
        public Dog(string name, uint age, double height, double weight, string devotion) :
            base(name, age, height, weight)
        {
            if (name == null)
                throw new NullReferenceException("name");
            Devotion = devotion;
        }
        void Read()
        {
            Console.WriteLine("Укажите привязанность вашей собаки:");
            Devotion = Convert.ToString(Console.Read());
            Console.WriteLine("");
        }
        void Display()
        {
            Console.WriteLine("Dog");
            Console.WriteLine($"Devotion:{Devotion}");
        }
    }
}
