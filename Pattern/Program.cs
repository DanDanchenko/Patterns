using System;
using System.Collections.Generic;
using ClassLibraryObjects;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IVoice> Animals = new List<IVoice>();
            Animals.Add(new Human("Cain", 12, "black"));
            Animals.Add(new Bird("Red", 14, "Red"));
            Animals.Add(new Bird("Nemo", 9, "Orange"));

            foreach (IVoice a in Animals)
            {
                a.Voice();
            }
            //----------------------------------------------------

            Hero elf = new Hero(new ElfFactory());

            elf.Hit();
            elf.Run();

            Hero voin = new Hero(new VoinFactory());

            voin.Hit();
            voin.Run();


        }
    }
}
