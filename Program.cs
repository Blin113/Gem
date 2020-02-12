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

            while (!quit)
            {
                List<Stats> statlist = new List<Stats>();

                statlist.Add(new Stats(5, 5, 5, 5, 5));

                String action = Console.ReadLine() + "";

                switch (action)
                {
                    case "1":

                        break;

                    case "2":
                        Console.Clear();
                        for (int i = 0; i < statlist.Count; i++)
                        {
                            Console.WriteLine("\n_____________________________________________________________________________");
                            Console.WriteLine("Str: " + statlist[i].Strength);
                            Console.WriteLine("Dex: " + statlist[i].Dexterity);
                            Console.WriteLine("Agi: " + statlist[i].Agility);
                            Console.WriteLine("Int: " + statlist[i].Inteligence);
                            Console.WriteLine("Luck: " + statlist[i].Luck);
                        }
                        Console.WriteLine("\n1. Add");
                        Console.WriteLine("2. Return");



                        Console.ReadKey();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
