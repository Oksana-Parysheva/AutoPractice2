using System;

namespace Pr2.ClassesAndStructs
{
    struct AnimalStruct
    {
        string name;
        static DateTime dateOfBirth;
        const Gender gender = Gender.Male;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Run()
        {
        }

        static AnimalStruct()
        {
            dateOfBirth = DateTime.Now;
        }

        public AnimalStruct(string name)
        {
            this.name = name;
            GotHungry = null;
        }

        private event EventHandler GotHungry;

        public static AnimalStruct operator +(AnimalStruct animal1, AnimalStruct animal2)
        {
            return new AnimalStruct();
        }

        public class Tail
        {

        }

        // struct
    }
}
