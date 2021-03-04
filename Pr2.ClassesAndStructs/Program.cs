namespace Pr2.ClassesAndStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Animal animal2 = new Animal("Cat");

            Animal animal3 = animal2;

            AnimalStruct animalStruct1 = new AnimalStruct();
            AnimalStruct animalStruct2 = new AnimalStruct("Dog");

            AnimalStruct animalStruct3 = animalStruct2;

            animal3.Name = "Cat 2";
            var res = animal2.Name.Equals(animal3.Name);
            animalStruct3.Name = "Dog 2";
        }
    }
}
