using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObjects
{
    // класс арбалет
    class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем из арбалета");
        }
    }
}
