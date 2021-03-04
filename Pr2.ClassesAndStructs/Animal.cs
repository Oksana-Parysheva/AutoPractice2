using System;

namespace Pr2.ClassesAndStructs
{
    internal class Animal
    {
        string name;
        static DateTime dateOfBirth;
        const Gender gender = Gender.Male;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        void Run()
        {
        }

        static void Bark()
        {
            Console.Write("Gav Gav!");
        }

        static Animal()
        {
            dateOfBirth = DateTime.Now;
        }

        public Animal()
        {

        }

        public Animal(string name)
        {
            Name = name;
        }

        private event EventHandler GotHungry;

        ~Animal()
        {

        }

        public class Tail
        {

        }
        // struct
    }
}
