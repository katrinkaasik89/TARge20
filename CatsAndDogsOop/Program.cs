using System;

namespace CatsAndDogsOop
{
    class Program
    {


        class Pet
        {
            public string name;
            public string color;
            public int levelOfHapiness;
            public void PrintPetInfo()

            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Hapiness level: {levelOfHapiness}");
            }
        }

        class Dog : Pet
        {
            public Dog(string _name, string _color) /*(konstruktr/ konstruktori nimi on sama, Mis klassil)*/
            {
                name = _name;
                color = _color;
                levelOfHapiness = 0;
            }
            public void WaveTail() /*meetod?*/
            {
                levelOfHapiness += 1;
            }
            public bool Bark() /*meetod peaks midagi tagastama*/
            {
                Console.WriteLine("Woof-woof");
                return true;
            }
        }
        class Cat : Pet
        {
            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                levelOfHapiness = 10;
            }
            public void HearTheDog()
            {
                levelOfHapiness = 0;
            }
            public void Hiss()
            {
                Console.WriteLine("Hsssss");
            }
        }   
               
        
         
                static void Main(string[] args)
        {
            Dog Rex = new Dog("Rex", "black and white"); /*(kutsun v2lja konstruktori)*/
            Rex.PrintPetInfo();
            Cat Garfield = new Cat("Garfield", "ginger");
            Garfield.PrintPetInfo();
            for (int i = 0; i < 8; i++)
            {
                Rex.WaveTail();
            }
            Rex.PrintPetInfo();

            bool dogBarked = Rex.Bark();
            if (Rex.Bark())
            {
                Garfield.HearTheDog();
            }
            if (Garfield.levelOfHapiness == 0)
            {
                Garfield.Hiss();
            }
        }
    }
}
