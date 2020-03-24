using System;
using System.Collections.Generic;
using System.Text;

namespace Gem
{
    class Stats
    {
        private int health;
        private int strength;
        private int dexterity;
        private int agility;
        private int inteligence;
        private int luck;
        private int statpoints;

        public Stats(int Hp, int Str, int Dex, int Agi, int Int, int Luc, int Pts)
        {
            health = Hp;
            strength = Str;
            dexterity = Dex;
            agility = Agi;
            inteligence = Int;
            luck = Luc;
            statpoints = Pts;
        }

        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    health = 0;
                }
                else
                {
                    strength = value;
                }
            }
        }

        public int Strength
        {
            get { return strength; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    strength = 0;
                }
                else
                {
                    strength = value;
                }
            }
        }

        public int Dexterity
        {
            get { return dexterity; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    dexterity = 0;
                }
                else
                {
                    dexterity = value;
                }
            }
        }

        public int Agility
        {
            get { return agility; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    agility = 0;
                }
                else
                {
                    agility = value;
                }
            }
        }

        public int Inteligence
        {
            get { return inteligence; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    inteligence = 0;
                }
                else
                {
                    inteligence = value;
                }
            }
        }

        public int Luck
        {
            get { return luck; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    luck = 0;
                }
                else
                {
                    luck = value;
                }
            }
        }

        public int Statpoints
        {
            get { return statpoints; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    statpoints = 0;
                }
                else
                {
                    statpoints = value;
                }
            }
        }
    }

    class Level
    {
        private int level;

        public Level(int Xp)
        {
            level = Xp;
        }

        public int Level
        {
            get { return level; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    level = 0;
                }
                else
                {
                    level = value;
                }
            }
        }
    }
}