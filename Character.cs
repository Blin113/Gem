using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Gem
{
    class Character : Stats     //a class for all the elements in entity. Also encoding the palyer stats so you can't cheat.
    {
        public Character(int Hp, int Str, int Dex, int Agi, int Int, int Luc, int Pts, int Lvl, int Xp, float atk, float def, float ddg, float crit) : base(Hp, Str, Dex, Agi, Int, Luc, Pts, Lvl, Xp, atk, def, ddg, crit)
        {
            
        }

        //Följande kod andvänder hashing aloritmen Sha1 för att kryptera player stats så att man inte kan fuska.
        //En fil skapas där statsen sparas rad för rad
        //statsen + ett hemligt lösenord krypteras så om något(någon stat i filen) ändras kommer du inte kunna spela.
        //
        //https://stackoverflow.com/questions/17292366/hashing-with-sha1-algorithm-in-c-sharp
        public static string GetSha1(string value)      //cheaters be ware, beat this. http://www.sha1-online.com/
        {
            var data = Encoding.ASCII.GetBytes(value);
            var hashData = new SHA1Managed().ComputeHash(data);
            var hash = string.Empty;
            foreach (var b in hashData)
            {
                hash += b.ToString("X2");
            }
            return hash;
        }

        public override string ToString()
        {
            string stats = Health.ToString() + "\n" + Strength.ToString() + "\n" + Dexterity.ToString() + "\n" + Agility.ToString() + "\n" + Inteligence.ToString() + "\n" + Luck.ToString() + "\n" + Statpoints.ToString() + "\n" + Level.ToString() + "\n" + ExperiencePoints.ToString();
            string hash = GetSha1("Blin113" + stats);       //blin113 is just here to make sure you can't cheat without access to the code.
            stats += "\n" + hash;
            return stats;
        }

        public void LoadFromFile(string file)       //what line holds what stat?
        {
            string[] lines = File.ReadAllLines(@file);
            Health = int.Parse(lines[0]);
            Strength = int.Parse(lines[1]);
            Dexterity = int.Parse(lines[2]);
            Agility = int.Parse(lines[3]);
            Inteligence = int.Parse(lines[4]);
            Luck = int.Parse(lines[5]);
            Statpoints = int.Parse(lines[6]);
            Level = int.Parse(lines[7]);
            ExperiencePoints = int.Parse(lines[8]);

            string appended = "";

            for(int i = 0; i < lines.Length - 1; i++)
            {
                appended += lines[i];
                appended += "\n";
            }

            if ((GetSha1("Blin113" + appended.Trim())) != lines[9])     //blin113 is just here to make sure you can't cheat without access to the code.
            { 
                File.Delete(@file);     //delete the modified file so the cheater has to start over.
                while (true)
                {
                    Console.WriteLine("Is only Gem, why u gotta cheat?");
                    for (int i = 37; i < 32767; i++)
                    {
                        Console.Beep(i, i);     //fuska inte med headset på!!!!!
                    }
                }
            }

            //Console.WriteLine(GetSha1("Blin113" + appended.Trim()));
        }
    }
}
