using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObjects
{
    // класс меч
    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}
