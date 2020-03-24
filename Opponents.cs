using System;
using System.Collections.Generic;
using System.Text;

namespace Gem
{
    class Opponents : Character
    {
        public Opponents(Stats stats)
        {
            this.stats = stats;
            punk();
        }
    }

    class Punk : Opponents
    {
        public Punk() : base()
        {

        }
    }
}
