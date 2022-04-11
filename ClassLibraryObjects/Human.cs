using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObjects
{
    public class Human : Animal, IMovable, IVoice
    {
        string SkinColor;
        public Human(string n, int a, string sk) : base (n,a)
        {
            SkinColor = sk;
            
        }

        public void Move()
        {
            Console.WriteLine("I am walking");
        }
        public void Voice()
        {
            Console.WriteLine("My name is " + GetName());
        }



        public override void Print()
        {
            base.Print();
            Console.WriteLine(" skin = " + SkinColor);

        }
    }
}
