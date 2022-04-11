using System;
using System.Collections.Generic;
using ClassLibraryObjects;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal p1 = new Animal("Adam", 33);
            //Animal p2 = new Animal("Eve", 33);

            //p1.SetAge(20);

            //p1.Print();
            //p2.Print();



            Human h1 = new Human("Cain", 12, "black");
            h1.Print();

            //h1.Voice();
            //h1.Move();
            //Bird bird1 = new Bird("Red", 14, "Red");
            //bird1.Move();
            //bird1.Voice();

            List<IVoice> Animals = new List<IVoice>();
            Animals.Add(new Human("Cain", 12, "black"));
            Animals.Add(new Bird("Red", 14, "Red"));
            Animals.Add(new Bird("Nemo", 9, "Orange"));

            foreach (IVoice a in Animals)
            {
                a.Voice();
            }

        }
    }
}
