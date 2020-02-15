using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        Console.WriteLine("Invalid Command, press any key to contionue");
                        Console.ReadKey();
                        Console.Clear();
                        Main(null);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Command, press any key to contionue");
                    Console.ReadKey();
                    Main(null);
                    break;
            }
            
            List<Stats> statlist = new List<Stats>();

            Random random = new Random();
            statlist.Add(new Stats(5, 5, 5, 5, 5, 0));
            String Player = statlist[0] + "";

            while (!quit)
            {
                Console.WriteLine("1. Fight");
                Console.WriteLine("2. Stats");
                String action = Console.ReadLine() + "";

                switch (action)
                {
                    case "1":   //Fight
                        int ES = random.Next(1, 10);
                        int ED = random.Next(1, 10);
                        int EA = random.Next(1, 10);
                        int EI = random.Next(1, 10);
                        int EL = random.Next(1, 10);
                        statlist.Add(new Stats(ES, ED, EA, EI, EL, 0));
                        break;

                    case "2":   //Player stats
                        Console.Clear();

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

                        if (statsmenu_action == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("1. Str: " + statlist[0].Strength);
                            Console.WriteLine("2. Dex: " + statlist[0].Dexterity);
                            Console.WriteLine("3. Agi: " + statlist[0].Agility);
                            Console.WriteLine("4. Int: " + statlist[0].Inteligence);
                            Console.WriteLine("5. Luck: " + statlist[0].Luck);
                            Console.WriteLine("_____________________________________________________________________________");
                            Console.WriteLine("Pts: " + statlist[0].Statpoints);

                            String add = Console.ReadLine() + "";
                            if (add == "1")
                            {
                                int ammount = int.Parse(Console.ReadLine());
                                if (ammount <= statlist[0].Statpoints && ammount >= 0)
                                {
                                    statlist[0].Strength += ammount;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid command!");
                                    break;
                                }
                                    
                        }
                        

                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Invalid command, press any key to continue");
                        Console.ReadKey();
                        
                        break;
                }
            }
        }
    }
}
