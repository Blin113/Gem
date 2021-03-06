﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gem
{
    class StatsModifier
    {
        public StatsModifier()
        {

        }

        public void StatsAssembly(ref Stats Stats)       //return atk, def, dodge and crit to program.cs for Fight();
        {
            float StrM = (Stats.Strength / 100) + 1;       //atk/def +
            float DexM = (Stats.Dexterity / 100) + 1;      //dodge/atk/crit/def +
            float AgiM = (Stats.Agility / 100) + 1;        //dodge +
            float IntM = (Stats.Inteligence / 100) + 1;    //Atk/Def/Crit +
            float LucM = (Stats.Luck / 100) + 1;           //dodge/crit +

            Stats.AtkMod = 0.1f * StrM * DexM * IntM;   //Calculates some modifiers
            Stats.DefMod = 0.1f * StrM * DexM * IntM;
            Stats.DodgeMod = 0.1f * DexM * AgiM * LucM; 
            Stats.CritMod = 0.1f * DexM * IntM * LucM;

            Stats.Attack = 100 * Stats.AtkMod;      //assembles Atk, def, dodge and crit
            Stats.Defence = 100 * Stats.DefMod;
            Stats.Dodge = 100 * Stats.DodgeMod;
            Stats.CriticalStrike = 100 * Stats.CritMod;
        }
    }
}

