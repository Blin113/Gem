using System;
using System.Collections.Generic;
using System.Text;

namespace Gem
{
    class Character
    {
        private Stats stats;
        private Level level;

        public Character(stats stats, Player player)
        {
            this.stats = stats;
            this.player = player;
        }

        public Stats stats
        {
            get { return stats; }
            set { stats = value; }
        }

        public Level level
        {
            get { return level; }
            set { level = value; }
        }
    }
}
