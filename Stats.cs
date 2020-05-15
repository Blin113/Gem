using System;
using System.Collections.Generic;
using System.Text;

namespace Gem
{
    class Stats
    {
        double XpCap = 100;     //the cap for each level, a criteria for the player to reach the next level.
        private int health;     //Health
        private int strength;       //atk/def +            these stats will be assembled to four variables: attack dmg, defence, dodge, ability power/mana? and critical strikes...
        private int dexterity;      //dodge/atk/crit +      a method or two will be made in order to merge these and then compare them in the fight method to see if the player is able to beat the enemy.
        private int agility;        //dodge +
        private int inteligence;    //Atk/Def/Crit +
        private int luck;       //dodge/crit +
        private int statpoints;
        int PtsMod = 5;
        private int level;
        private int experiencePoints;

        private float attack;
        private float defence;
        private float dodge;
        private float criticalstrike;

        private float atkMod;
        private float defMod;
        private float dodgeMod;
        private float critMod;

        public Stats(int Hp, int Str, int Dex, int Agi, int Int, int Luc, int Pts,int Lvl, int Xp, float atk, float def, float ddg, float crit, float AtkM, float DefM, float DdgM, float CritM)
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

            atkMod = AtkM;
            defMod = DefM;
            dodgeMod = DdgM;
            critMod = CritM;
        }

        public Stats(int Hp, int Str, int Dex, int Agi, int Int, int Luc, int Pts, int Lvl, int Xp, float atk, float def, float ddg, float crit)
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
                    health = 0;
                }
                else
                {
                    health = value;
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

        public float Attack     //"summarise" stats to this value
        {
            get { return attack; }
            set
            {


                if (value < 0)
                {
                    Console.WriteLine("Invalid stats, attack cannot be lower than 0. please restart your game.");
                    attack = 0;
                }
                else
                {
                    attack = value;
                }
            }
        }

        public float Defence     //"summarise" stats to this value
        {
            get { return defence; }
            set
            {


                if (value < 0)
                {
                    Console.WriteLine("Invalid stats, defence cannot be lower than 0. please restart your game.");
                    defence = 0;
                }
                else
                {
                    defence = value;
                }
            }
        }

        public float Dodge     //"summarise" stats to this value
        {
            get { return dodge; }
            set
            {


                if (value < 0)
                {
                    Console.WriteLine("Invalid stats, dodge cannot be lower than 0. please restart your game.");
                    dodge = 0;
                }
                else
                {
                    dodge = value;
                }
            }
        }

        public float CriticalStrike     //"summarise" stats to this value
        {
            get { return criticalstrike; }
            set
            {


                if (value < 0)
                {
                    Console.WriteLine("Invalid stats, Crit cannot be lower than 0. please restart your game.");
                    criticalstrike = 0;
                }
                else
                {
                    criticalstrike = value;
                }
            }
        }

        public float AtkMod
        {
            get { return atkMod; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    atkMod = 0;
                }
                else
                {
                    atkMod = value;
                }
            }
        }

        public float DefMod
        {
            get { return defMod; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    defMod = 0;
                }
                else
                {
                    defMod = value;
                }
            }
        }

        public float DodgeMod
        {
            get { return dodgeMod; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    dodgeMod = 0;
                }
                else
                {
                    dodgeMod = value;
                }
            }
        }

        public float CritMod
        {
            get { return critMod; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                    critMod = 0;
                }
                else
                {
                    critMod = value;
                }
            }
        }

        public string CheckLevelUp(ref Stats Stats)
        {
            Stats.ExperiencePoints += 100;

            if (Stats.ExperiencePoints >= Stats.XpCap)
            {
                Stats.level += 1;
                Stats.XpCap = Math.Pow(Stats.XpCap, 1.2) * 1.5;
                
                Math.Round(Stats.Health * 1.5);

                
                Stats.Statpoints += Stats.PtsMod;
                Stats.PtsMod += 2;
                
                return "You leveled up!";
            }
            else
            {
                return "";
            }
        }

        
    }
}