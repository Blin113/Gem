using System;
using System.Collections.Generic;
using System.Text;

namespace Gem
{
    class Stats
    {
        double XpCap = 100;     //the cap for each level, a criteria for the player to reach the next level.
        private int health;     //Health
        private int strength;       //atk +                 these stats will be assembled to four variables: attack dmg, defence, dodge, ability power/mana? and critical strikes...
        private int dexterity;      //dodge/atk/crit +           a method or two will be made in order to merge these and then compare these in the fight method to see if the player is able to beat the enemy.
        private int agility;        //dodge +
        private int inteligence;    //Ap +??
        private int luck;       //dodge/crit +
        private int statpoints;
        private int level;
        private int experiencePoints;

        private float attack;
        private float defence;
        private float dodge;
        private float criticalstrike;

        public Stats(int Hp, int Str, int Dex, int Agi, int Int, int Luc, int Pts,int Lvl, int Xp, float atk, float def, float ddg, float crit)
        {
            health = Hp;
            strength = Str;
            dexterity = Dex;
            agility = Agi;
            inteligence = Int;
            luck = Luc;
            statpoints = Pts;
            level = Lvl;
            experiencePoints = Xp;

            attack = atk;
            defence = def;
            dodge = ddg;
            criticalstrike = crit;
        }

        public Stats()
        {

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

        public int ExperiencePoints
        {
            get { return experiencePoints; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    experiencePoints = 0;
                }
                else
                {
                    experiencePoints = value;
                }
            }
        }

        public void CheckLevelUp()
        {
            if (experiencePoints >= XpCap)
            {
                level += 1;
                XpCap = Math.Log(XpCap)*XpCap;
            }
            else
            {
                return;
            }
        }

        public int StatsAssembly()
        {
            get{ return attack defence dodge criticalstrike; }
        }
    }
}