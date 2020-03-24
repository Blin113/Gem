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

            List<Character> entity = new List<Character>();
    
            entity.Add(new Player(new Character(10, 5, 5, 5, 5, 5, 10)));      //player stats
            String Player = statlist[0] + "";

            Player = &entity[0];

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
                        Console.WriteLine(Oponent());
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("1. Fight");
                        Console.WriteLine("2. Run");
                        Console.WriteLine("3. Items(WIP)");     //Add after u git gud
                        String Fightoptions = Console.ReadLine() + "";
                        switch (Fightoptions)
                        {
                            case "1":
                                //Fighting code
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

                    case "2":   //Player stats
                        Console.Clear();
                        Console.WriteLine("Str: " + statlist[0].Health);
                        Console.WriteLine("Str: " + statlist[0].Strength);
                        Console.WriteLine("Dex: " + statlist[0].Dexterity);
                        Console.WriteLine("Agi: " + statlist[0].Agility);
                        Console.WriteLine("Int: " + statlist[0].Inteligence);
                        Console.WriteLine("Luck: " + statlist[0].Luck);
                        Console.WriteLine("_____________________________________________________________________________");
                        Console.WriteLine("Pts: " + statlist[0].Statpoints);

                        Console.WriteLine("\n1. Add");
                        Console.WriteLine("Press any other button to return");
                        string statsmenu_action = Console.ReadLine() + "";

                        switch (statsmenu_action)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("1. Str: " + statlist[0].Strength);
                                Console.WriteLine("2. Dex: " + statlist[0].Dexterity);
                                Console.WriteLine("3. Agi: " + statlist[0].Agility);
                                Console.WriteLine("4. Int: " + statlist[0].Inteligence);
                                Console.WriteLine("5. Luck: " + statlist[0].Luck);
                                Console.WriteLine("_____________________________________________________________________________");
                                Console.WriteLine("Pts: " + statlist[0].Statpoints);

                                String add = Console.ReadLine() + "";       //add to stats from statpoints
                                switch (add)
                                {
                                    case "1":
                                        Console.WriteLine("How much do you want to put into strenght?");
                                        int ammount = int.Parse(Console.ReadLine());
                                        if (ammount <= statlist[0].Statpoints && ammount >= 0)
                                        {
                                            statlist[0].Strength += ammount;
                                            statlist[0].Statpoints -= ammount;
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
                                        if (ammount <= statlist[0].Statpoints && ammount >= 0)
                                        {
                                            statlist[0].Dexterity += ammount;
                                            statlist[0].Statpoints -= ammount;
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
                                        if (ammount <= statlist[0].Statpoints && ammount >= 0)
                                        {
                                            statlist[0].Agility += ammount;
                                            statlist[0].Statpoints -= ammount;
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
                                        if (ammount <= statlist[0].Statpoints && ammount >= 0)
                                        {
                                            statlist[0].Inteligence += ammount;
                                            statlist[0].Statpoints -= ammount;
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
                                        if (ammount <= statlist[0].Statpoints && ammount >= 0)
                                        {
                                            statlist[0].Luck += ammount;
                                            statlist[0].Statpoints -= ammount;
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
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Invalid Command, press any key to contionue");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                        break;

                    case "3":       //Quit game
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

        static string Oponent()
        {
            List<Opponents> opponent = new List<Opponents>();
        }
    }
}