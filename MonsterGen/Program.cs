using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MonsterGen
{

    class Program
    {
        private static Random rng = new Random();
        private static string prefixPath = Environment.CurrentDirectory + "/prefix.txt";
        private static string nameBasePath = Environment.CurrentDirectory + "/nameBase.txt";
        private static string suffixPath = Environment.CurrentDirectory + "/suffix.txt";

        public static bool showStartupMessage = true;
        public static List<string> prefix = new List<string>();
        public static List<string> nameBase = new List<string>();
        public static List<string> suffix = new List<string>();

        static void Main(string[] args)
        {
            if (showStartupMessage)
            {
                Console.WriteLine("Press enter to generate, press any other button to quit");
                showStartupMessage = false;
            }
            GetLists();
            GetUserInput();
        }

        private static void GetUserInput()
        {
            if(Console.ReadKey().Key == ConsoleKey.Enter)
            {
                OutputMonster();
                GetUserInput();
            }
        }

        private static string GenerateMonster()
        {
            return "Monster: " + prefix[rng.Next(prefix.Count)] + " " + nameBase[rng.Next(nameBase.Count)] + " " + suffix[rng.Next(suffix.Count)];
        }

        private static void OutputMonster()
        {
            Console.WriteLine(GenerateMonster());
        }

        private static void GetLists()
        {
            try
            {
                if (File.Exists(prefixPath))
                {
                    var fileContent = File.ReadAllLines(prefixPath);
                    foreach (string s in fileContent)
                    {
                        prefix.Add(s);
                    }
                }
                if (File.Exists(nameBasePath))
                {
                    var fileContent = File.ReadAllLines(nameBasePath);
                    foreach (string s in fileContent)
                    {
                        nameBase.Add(s);
                    }
                }
                if (File.Exists(suffixPath))
                {
                    var fileContent = File.ReadAllLines(suffixPath);
                    foreach (string s in fileContent)
                    {
                        suffix.Add(s);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " | " + e.Source);
            }
            
        }
    }
}
