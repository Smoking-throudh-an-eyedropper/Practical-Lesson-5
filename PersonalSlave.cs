using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lesson_5
{
    internal class PersonalSlave: Animal
    {
        private string Submission;
        public PersonalSlave(string name, uint age, double height, double weight, string submission) :
            base(name, age, height, weight)
        {
            if (name == null)
                throw new NullReferenceException("name");
            Submission = submission;
        }
        void Read()
        {
            Console.WriteLine("Укажите покорность your personal slave:");
            Submission = Convert.ToString(Console.Read());
            Console.WriteLine("");
        }
        void Display()
        {
            Console.WriteLine("Dog");
            Console.WriteLine($"Submission:{Submission}");
        }
    }
}
