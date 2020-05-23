using System;
using System.Collections.Generic;
using System.IO;

namespace Gem
{
    class Program
    {
        static string Load;     //for loading save files
        static List<Character> entity = new List<Character>();      //creating the entity list where my enemies and the player stats/inventory will be stored
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Gem by Blin";
            string title = @"

 ________  _______   _____ ______           ________      ___    ___      ________  ___       ___  ________      
|\   ____\|\  ___ \ |\   _ \  _   \        |\   __  \    |\  \  /  /|    |\   __  \|\  \     |\  \|\   ___  \    
\ \  \___|\ \   __/|\ \  \\\__\ \  \       \ \  \|\ /_   \ \  \/  / /    \ \  \|\ /\ \  \    \ \  \ \  \\ \  \   
 \ \  \  __\ \  \_|/_\ \  \\|__| \  \       \ \   __  \   \ \    / /      \ \   __  \ \  \    \ \  \ \  \\ \  \  
  \ \  \|\  \ \  \_|\ \ \  \    \ \  \       \ \  \|\  \   \/  /  /        \ \  \|\  \ \  \____\ \  \ \  \\ \  \ 
   \ \_______\ \_______\ \__\    \ \__\       \ \_______\__/  / /           \ \_______\ \_______\ \__\ \__\\ \__\
    \|_______|\|_______|\|__|     \|__|        \|_______|\___/ /             \|_______|\|_______|\|__|\|__| \|__|
                                                
                                            Press any key to start

            ";      //a nice little startup screen


            Console.WriteLine(title);       //prints the startup screen/text
            Console.ReadKey();
            //Console.ResetColor();

            Console.Clear();
            bool quit = true;

            Console.WriteLine("1. Play");
            Console.WriteLine("2. Quit");
            string Do = Console.ReadLine();
            Console.Clear();

            switch (Do)
            {
                case "1":
                    Console.WriteLine("Load game?\n");

                    bool is1Avaliable = File.Exists(@"./save1.txt");        //kollar om filen save1 2 eller 3  finns så den kan
                    bool is2Avaliable = File.Exists(@"./save2.txt");
                    bool is3Avaliable = File.Exists(@"./save3.txt");
                    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
                    Console.WriteLine(is1Avaliable ? "1. Load save 1" : "1. Empty slot");
                    Console.WriteLine(is2Avaliable ? "2. Load save 2" : "2. Empty slot");
                    Console.WriteLine(is3Avaliable ? "3. Load save 3" : "3. Empty slot");

                    Load = Console.ReadLine().Trim();

                    switch (Load)
                    {
                        case "1":
                            if (is1Avaliable)       //kollar om filen save 1 existerar, om inte skapar vi en ny senare när vi sparar spelet.
                            {
                                if (entity.Count == 0)
                                {
                                    entity.Add(new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                                    entity[0].LoadFromFile(@"./save1.txt");
                                    break;
                                }

                                for (int i = 0; i < entity.Count; i++)
                                {
                                    if (entity[i] is Player)
                                    {
                                        entity.Add(new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                                        entity[0].LoadFromFile(@"./save1.txt");
                                    }

                                }

                                Console.Clear();
                                break;
                            }
                            else
                            {
                                if (entity.Count == 0)
                                {
                                    entity.Add(new Player(20, 5, 5, 5, 5, 5, 10, 1, 0, 0, 0, 0, 0));
                                }
                                else
                                {
                                    entity[0] = (new Player(20, 5, 5, 5, 5, 5, 10, 1, 0, 0, 0, 0, 0));
                                }

                                quit = false;
                                Console.Clear();
                                break;
                            }

                        case "2":
                            if (is2Avaliable)       //kollar om filen save 2 existerar, om inte skapar vi en ny senare när vi sparar spelet.
                            {
                                if (entity.Count == 0)
                                {
                                    entity.Add(new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                                    entity[0].LoadFromFile(@"./save2.txt");
                                    break;
                                }

                                for (int i = 0; i < entity.Count; i++)
                                {
                                    if (entity[i] is Player)
                                    {
                                        entity.Add(new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                                        entity[0].LoadFromFile(@"./save2.txt");
                                    }

                                }

                                Console.Clear();
                                break;
                            }
                            else
                            {
                                if (entity.Count == 0)
                                {
                                    entity.Add(new Player(20, 5, 5, 5, 5, 5, 10, 1, 0, 0, 0, 0, 0));
                                }
                                else
                                {
                                    entity[0] = (new Player(20, 5, 5, 5, 5, 5, 10, 1, 0, 0, 0, 0, 0));
                                }

                                quit = false;
                                Console.Clear();
                                break;
                            }

                        case "3":
                            if (is3Avaliable)       //kollar om filen save 3 existerar, om inte skapar vi en ny senare när vi sparar spelet.
                            {
                                if (entity.Count == 0)
                                {
                                    entity.Add(new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                                    entity[0].LoadFromFile(@"./save3.txt");
                                    break;
                                }

                                for (int i = 0; i < entity.Count; i++)
                                {
                                    if (entity[i] is Player)
                                    {
                                        entity.Add(new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                                        entity[0].LoadFromFile(@"./save3.txt");
                                    }

                                }

                                Console.Clear();
                                break;
                            }
                            else
                            {
                                if (entity.Count == 0)
                                {
                                    entity.Add(new Player(20, 5, 5, 5, 5, 5, 10, 1, 0, 0, 0, 0, 0));
                                }
                                else
                                {
                                    entity[0] = (new Player(20, 5, 5, 5, 5, 5, 10, 1, 0, 0, 0, 0, 0));
                                }

                                quit = false;
                                Console.Clear();
                                break;
                            }

                        default:
                            Console.WriteLine("Invalid Save File.");     //användaren skrev fel
                            Console.ReadKey();
                            Console.Clear();
                            Main(null);
                            break;

                    }

                    Console.Clear();
                    quit = false;
                    break;

                case "2":
                    Console.WriteLine("Quit? (Y/N)");
                    string QT = Console.ReadLine().ToLower();
                    if (QT == "y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (QT == "n")
                    {
                        Console.Clear();
                        Main(null);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid Command, press any key to contionue");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.ReadKey();
                        Console.Clear();
                        Main(null);
                    }
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Command, press any key to contionue");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.ReadKey();
                    Main(null);
                    break;
            }

            while (!quit)       //actual game
            {
                Console.Clear();
                Console.WriteLine("1. Fight");
                Console.WriteLine("2. Stats");
                Console.WriteLine("3. Inventory");      //hinner tyvärr inte göra klart items då jag måste lämna in projektet.
                Console.WriteLine("4. Exit");
                string action = Console.ReadLine() + "";
                bool Over = false;

                switch (action)
                {
                    case "1":   //Fight

                        if (Over == true)    //leave the fighting case if the fight is over
                        {
                            break;
                        }

                        CallOpponent(ref entity);
                        Stats Stats = entity[0];    //Player stats
                        Stats EStats = entity[1];   //Enemy stats

                        int Maxhp = Stats.Health;   //Player maximum hp
                        int EMaxhp = EStats.Health; //Enemy maximum hp

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(OpponentPhrase());        //who you are fighting
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("----------------------------------");

                        while (Stats.Health > 0 || EStats.Health > 0)
                        {
                            if (Over == true)       //leave the fighting case if the fight is over
                            {
                                goto case "1";
                            }

                            Console.WriteLine("Your HP: " + Stats.Health);
                            Console.WriteLine("Enemy HP: " + EStats.Health);
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("1. Fight");
                            Console.WriteLine("2. Run");
                            Console.WriteLine("3. Inventory");     //hinner tyvärr inte göra klart items då jag måste lämna in projektet.

                            string Fightoptions = Console.ReadLine() + "";
                            switch (Fightoptions)
                            {
                                case "1":   //Fighting case

                                    Fight(Stats, EStats);       //take and deal damage...(see Fight();)

                                    if (EStats.Health <= 0 && Stats.Health > 0)     //if you kill your enemy...
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You have slain your enemy!");

                                        var instance = new Stats();
                                        Console.WriteLine(instance.CheckLevelUp(ref Stats, ref Maxhp, ref EMaxhp));

                                        Console.WriteLine("Current Xp: ");

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(Stats.ExperiencePoints);      //exp gained
                                        Console.ForegroundColor = ConsoleColor.Black;

                                        Stats.Health = Maxhp;       //reset Player hp
                                        EStats.Health = EMaxhp;     //reset Enemy hp

                                        Console.ReadKey();
                                        Over = true;
                                        break;
                                    }
                                    else if (Stats.Health <= 0)     //if you die...
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You died, press any key to continue");

                                        Stats.Health = Maxhp;       //reset Player hp
                                        EStats.Health = EMaxhp;     //reset Enemy hp

                                        Console.ReadKey();
                                        Over = true;
                                        break;
                                    }

                                    Console.Clear();
                                    break;

                                case "2":       //Flee...
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Opponent: COWARD!!!");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.ReadKey();

                                    Stats.Health = Maxhp;   //reset Player hp
                                    EStats.Health = EMaxhp; //reset Enemy hp
                                    Over = true;
                                    break;

                                case "3":       //hinner tyvärr inte göra klart items då jag måste lämna in projektet.
                                    //var instance3 = new Items();
                                    //Inventory(ref Items);    //displays your inventory

                                    Console.ReadKey();
                                    break;

                                default:
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Invalid option, press any key to continue");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    break;

                            }
                        }
                        break;

                    case "2":   //Player stats      Stat config add stats from your statpoints to stats
                        Console.Clear();
                        Console.WriteLine("Hp: " + entity[0].Health);       //skriver ut stats för health osv
                        Console.WriteLine("Str: " + entity[0].Strength);
                        Console.WriteLine("Dex: " + entity[0].Dexterity);
                        Console.WriteLine("Agi: " + entity[0].Agility);
                        Console.WriteLine("Int: " + entity[0].Inteligence);
                        Console.WriteLine("Luck: " + entity[0].Luck);
                        Console.WriteLine("_____________________________________________________________________________");
                        Console.WriteLine("Lvl: " + entity[0].Level);
                        Console.WriteLine("Pts: " + entity[0].Statpoints);

                        Console.WriteLine("\n1. Add");
                        Console.WriteLine("Press any other button to return");
                        string statsmenu_action = Console.ReadLine() + "";

                        switch (statsmenu_action)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("1. Str: " + entity[0].Strength);
                                Console.WriteLine("2. Dex: " + entity[0].Dexterity);
                                Console.WriteLine("3. Agi: " + entity[0].Agility);
                                Console.WriteLine("4. Int: " + entity[0].Inteligence);
                                Console.WriteLine("5. Luck: " + entity[0].Luck);
                                Console.WriteLine("_____________________________________________________________________________");
                                Console.WriteLine("Pts: " + entity[0].Statpoints);

                                string add = Console.ReadLine() + "";       //add to stats from statpoints
                                switch (add)
                                {
                                    case "1":
                                        Console.WriteLine("How much do you want to put into strenght?");
                                        int ammount = int.Parse(Console.ReadLine());
                                        if (ammount <= entity[0].Statpoints && ammount >= 0)
                                        {
                                            entity[0].Strength += ammount;
                                            entity[0].Statpoints -= ammount;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("No can do");
                                            Console.ReadKey();
                                            break;
                                        }


                                    case "2":
                                        Console.WriteLine("How much do you want to put into dexterity?");
                                        ammount = int.Parse(Console.ReadLine());
                                        if (ammount <= entity[0].Statpoints && ammount >= 0)
                                        {
                                            entity[0].Dexterity += ammount;
                                            entity[0].Statpoints -= ammount;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("No can do");
                                            Console.ReadKey();
                                            break;
                                        }

                                    case "3":
                                        Console.WriteLine("How much do you want to put into agility?");
                                        ammount = int.Parse(Console.ReadLine());
                                        if (ammount <= entity[0].Statpoints && ammount >= 0)
                                        {
                                            entity[0].Agility += ammount;
                                            entity[0].Statpoints -= ammount;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("No can do");
                                            Console.ReadKey();
                                            break;
                                        }

                                    case "4":
                                        Console.WriteLine("How much do you want to put into inteligence?");
                                        ammount = int.Parse(Console.ReadLine());
                                        if (ammount <= entity[0].Statpoints && ammount >= 0)
                                        {
                                            entity[0].Inteligence += ammount;
                                            entity[0].Statpoints -= ammount;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("No can do");
                                            Console.ReadKey();
                                            break;
                                        }

                                    case "5":
                                        Console.WriteLine("How much do you want to put into luck?");
                                        ammount = int.Parse(Console.ReadLine());
                                        if (ammount <= entity[0].Statpoints && ammount >= 0)
                                        {
                                            entity[0].Luck += ammount;
                                            entity[0].Statpoints -= ammount;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("No can do");
                                            Console.ReadKey();
                                            break;
                                        }

                                    default:
                                        Console.WriteLine("No can do");
                                        Console.ReadKey();
                                        break;
                                }
                                break;


                            default:
                                Console.Clear();
                                break;
                        }
                        break;

                    case "3":       //hinner tyvärr inte göra klart items då jag måste lämna in projektet.
                        Console.WriteLine("it seems you forgot your backpack at home sry.");

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":       //Quit game?
                        Console.Clear();
                        Console.WriteLine("Save game and exit? (Y/N)");     //save and exit?
                        string QT = Console.ReadLine().ToLower();
                        if (QT == "y")      //wich file?
                        {
                            if (Load == "1")        //save to load 1...
                            {
                                string[] lines = { entity[0].ToString() };
                                System.IO.File.WriteAllLines(@"./save1.txt", lines);
                            }
                            else if (Load == "2")        //save to load 2...
                            {
                                string[] lines = { entity[0].ToString() };
                                System.IO.File.WriteAllLines(@"./save2.txt", lines);
                            }
                            else if (Load == "3")        //save to load 3...
                            {
                                string[] lines = { entity[0].ToString() };
                                System.IO.File.WriteAllLines(@"./save3.txt", lines);
                            }
                            else
                            {
                                Console.WriteLine("What did you do this time?");        //någon har lyckats komma till den här raden... på nått sätt
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                            Console.Clear();
                            Main(null);
                            break;
                        }
                        else if (QT == "n")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Invalid Command, press any key to contionue");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid Command, press any key to contionue");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void CallOpponent(ref List<Character> entity)    //Enemy creation
        {
            if (entity.Count > 1)       //tar bort fienden om det finns någon.
            {
                entity.Remove(entity[1]);
            }

            entity.Add(new Opponents(15, 3, 3, 3, 3, 3, 0, 1, 0, 0, 0, 0, 0));      //skapar fienden
        }

        static string OpponentPhrase()          //returns a phrase for the epicness of the battle
        {
            Random random = new Random();

            List<string> Ep = new List<string>();       //Enemy phrase
            Ep.Add("A wild gardener has appeared");
            Ep.Add("A wild bird has appeared");
            Ep.Add("A wild painter has appeared");
            Ep.Add("A wild god has appeared");
            Ep.Add("A wild punk has appeared");
            Ep.Add("A wild martial artist has appeared");
            Ep.Add("A wild construction worker has appeared");
            Ep.Add("A wild penguin has appeared");
            Ep.Add("A wild worker has appeared");
            Ep.Add("A wild Bela has appeared");     //thx for help
            Ep.Add("A wild Firi has appeared");     //thx for help
            Ep.Add("A wild Måns has appeared");     //thx for help
            Ep.Add("A wild Tim Tuvestam has appeared");     //thx for help
            Ep.Add("A wild David Wernow has appeared");     //thx for help

            int i = random.Next(0, Ep.Count);

            return Ep[i];
        }

        static void Fight(Stats Stats, Stats EStats)     //fighting method
        {
            var instance2 = new StatsModifier();
            instance2.StatsAssembly(ref Stats);     //player statsassembly
            instance2.StatsAssembly(ref EStats);    //enemy statsassembly

            int Crit = (int)Stats.CriticalStrike;
            int MaxDamage = 0;

            Random random = new Random();
            int Rand = random.Next(1, 100);
            if (Rand <= Crit)       //Do Damage
            {
                MaxDamage = (int)Stats.Attack * 2;
            }
            else
            {
                MaxDamage = (int)Stats.Attack;
            }

            if (Rand <= EStats.Dodge)
            {
                MaxDamage = 0;
            }

            int FinalDamageGiven = MaxDamage - ((int)EStats.Defence / 5);
            FinalDamageGiven = Math.Max(FinalDamageGiven, 0);

            int ECrit = (int)EStats.CriticalStrike;
            int EMaxDamage = 0;

            Rand = random.Next(1, 100);
            if (Rand <= ECrit)       //take Damage
            {
                EMaxDamage = (int)EStats.Attack * 2;
            }
            else
            {
                EMaxDamage = (int)EStats.Attack;
            }

            if (Rand <= EStats.Dodge)
            {
                EMaxDamage = 0;
            }

            int FinalDamageTaken = EMaxDamage - (int)(Stats.Defence * 0.5);
            FinalDamageTaken = Math.Max(FinalDamageTaken, 0);

            EStats.Health -= FinalDamageGiven;      //subtraherar FinalDamageGiven från fiendens HP
            Stats.Health -= FinalDamageTaken;        //subtraherar FinalDamageTaken från spelarens HP
        }

        static void Inventory(ref Items Items)        //Invetory, används aldrig då jag inte gjort klart den.
        {
            List<Items> HealthPotions = new List<Items>();

        }

    }
}