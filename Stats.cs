using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Stats
    {
        private int strength;
        private int dexterity;
        private int agility;
        private int inteligence;
        private int luck;

        public Stats(int Str, int Dex, int Agi, int Int, int Luc)
        {
            strength = Str;
            dexterity = Dex;
            agility = Agi;
            inteligence = Int;
            luck = Luc;
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
    }
}
