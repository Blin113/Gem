using System;
using System.Collections.Generic;

namespace Gem
{
    class Program
    {
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

                                                     1337
            ";


            Console.WriteLine(title);
            Console.ReadKey();
            //Console.ResetColor();

            Console.Clear();
            bool quit = true;

            Console.WriteLine("1. Play");
            Console.WriteLine("2. Quit");
            String Do = Console.ReadLine();

            switch (Do)
            {
                case "1":
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

            var instance = new Stats();
            instance.StatsAssembly();

            List<Character> entity = new List<Character>();

            entity.Add(new Player(10, 5, 5, 5, 5, 5, 10, 1, 0));      //player stats
            
            while (!quit)       //actual game
            {
                Console.Clear();
                Console.WriteLine("1. Fight");
                Console.WriteLine("2. Stats");
                Console.WriteLine("3. Exit");
                String action = Console.ReadLine() + "";

                switch (action)
                {
                    case "1":   //Fight
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(OpponentPhrase());
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("1. Fight");
                        Console.WriteLine("2. Run");
                        Console.WriteLine("3. Items(WIP)");     //Add after u git gud
                        String Fightoptions = Console.ReadLine() + "";
                        switch (Fightoptions)
                        {
                            case "1":
                                Fight();

                                var instance = new Stats();
                                instance.CheckLevelUp();
                                break;

                            case "2":
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Opponent: COWARD!!!");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.ReadKey();
                                break;

                            default:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Invalid option, press any key to continue");
                                Console.ForegroundColor = ConsoleColor.Black;
                                break;
                        }
                        break;

                    case "2":   //Player stats      Stat config
                        Console.Clear();
                        Console.WriteLine("Str: " + entity[0].Health);
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

                                String add = Console.ReadLine() + "";       //add to stats from statpoints
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

                    case "3":       //Quit game?
                        Console.Clear();
                        Console.WriteLine("Exit? (Y/N)");
                        string QT = Console.ReadLine().ToLower();
                        if (QT == "y")
                        {
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

        static void Opponent(ref List<Character> entity)    //Enemy creation
        {
            entity.Remove(entity[1]);
            Random random = new Random();

            

            entity.Add(new Opponents(10, 5, 5, 5, 5, 5, 10, 1, 0));
        }

        static String OpponentPhrase()          //returns a phrase for the epicness of the battle
        {
            Random random = new Random();

            List<String> Ep = new List<string>();       //Enemy phrase
            Ep.Add("A wild gardener has appeared");
            Ep.Add("A wild bird has appeared");
            Ep.Add("A wild painter has appeared");
            Ep.Add("A wild god has appeared");
            Ep.Add("A wild punk has appeared");
            Ep.Add("A wild worker has appeared");
            Ep.Add("A wild Bela has appeared");
            Ep.Add("A wild firi has appeared");
            Ep.Add("A wild ... has appeared");

            int i = random.Next(0, Ep.Count);

            return Ep[i];
        }

        static void Fight()
        {

        }
    }
}