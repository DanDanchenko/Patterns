using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObjects
{
    // движение полета
    class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Летим");
        }
    }
}
