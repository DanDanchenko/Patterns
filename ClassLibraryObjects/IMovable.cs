using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObjects
{
    interface IMovable
    {
        
        const int minSpeed = 0;
        const int maxSpeed = 60;

        void Move();
    }
}
