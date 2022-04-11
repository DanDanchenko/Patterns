using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObjects
{
    public abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
}
