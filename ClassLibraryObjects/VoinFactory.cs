using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObjects
{
    public class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
