using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObjects
{
    public class Bird : Animal, IMovable, IVoice
    {

        string SkinColor;
        public Bird(string n, int a, string sk) : base(n, a)
        {
            SkinColor = sk;

        }

        public void Move()
        {
            Console.WriteLine("I am flying");
        }
        public void Voice()
        {
            Console.WriteLine("Pi pi pi");
        }

    }
}
