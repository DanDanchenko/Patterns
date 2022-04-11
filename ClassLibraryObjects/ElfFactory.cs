using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryObjects
{
    // Фабрика создания летящего героя с арбалетом
    public class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}
