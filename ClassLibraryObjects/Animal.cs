using System;

namespace ClassLibraryObjects
{
    public class Animal
    {
        string name = "Undefined";   // имя
        int age;

        // возраст

        public Animal(string n, int a)
        {
            name = n;
            age = a;
        }

        public void SetName(string n)
        {
            name = n;
        }


        public string GetName()
        {
            return name;
        }

        public void SetAge(int a)
        {
            age = a;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
}
