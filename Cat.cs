using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lesson_5
{
    internal class Cat: Animal
    {
        private string Breed;
        public Cat(string name, uint age, double height, double weight, string breed) :
            base(name, age, height, weight)
        {
            if (name == null)
                throw new NullReferenceException("name");
            Breed = breed;
        }
        void Read()
        {
            Console.WriteLine("Укажите породу вашей кошки:");
            Breed = Convert.ToString(Console.Read());
            Console.WriteLine("");
        }
        void Display()
        {
            Console.WriteLine("Cat");
            Console.WriteLine($"Breed:{Breed}");
        }
    }
}
