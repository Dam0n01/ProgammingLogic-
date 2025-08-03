namespace Lab5
{
    // step 1 - Base class
    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("Animal Makes Sound");
        }
    }
    // step 2- Derived classes
    class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Cat says: Meow");
        }
    }
    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Dog says: Bow wow");
        }
    }
    // step 3 - Test in Main
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.AnimalSound();

            Cat myCat = new Cat();
            myCat.AnimalSound();

            Dog myDog = new Dog();
            myDog.AnimalSound();



        }

    }
}
