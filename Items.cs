using System;
using System.Collections.Generic;
using System.Text;

namespace Gem       //hinner tyvärr inte göra klart items då jag måste lämna in projektet.
{
    enum ItemState
    {
        equipped,
        active
    }

    class Items : Stats
    {
        private int damage;
        private int defence;
        private int healing;

        public Items(int dmg, int defe, int reg)
        {
            damage = dmg;
            defence = defe;
            healing = reg;
        }
    }

}
