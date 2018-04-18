using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGen
{

    class Program
    {
        public static bool showStartupMessage = true;


        static void Main(string[] args)
        {
            if (showStartupMessage)
            {
                Console.WriteLine("Press enter to generate, press any other button to quit");
                showStartupMessage = false;
            }
            Random rng = new Random();
            string[] prefix = {"immortal","dank","were","dark","bloody","cruel","golden","punishment","garbage","monster","ninja","skater","goth","nerdy","popular","crazy","muscular","queen","king","homo","filthy","ancient","heavy","holy","master of","savage","asian","european","african","american","french","latino","fire","water","earth","air","smart","deadly","super","fast","flying","raging","japanese","atomic","nuclear","poisonous","venomous","lesser","greater","russian","furry","otaku","stoner","rock","hipster","punk","gopnik","double","stripper","confused","sexy","surf","scary","money","drag","man","woman","fancy","cyber","mutant","ultimate","mecha","divine","metal","legendary","armoured" };
            string[] second = { "widow","nun","deamon","vampire","man","woman","punishment","garbage","doctor","worm","bat","pumpkin","wraith","bubble gum","dinosaur","fish","mutant","pizza","samurai","shield","egg","wolf", "zombie", "cat", "witch", "skeleton", "hero", "monster", "car", "lizard", "weapon", "turtle", "dragon", "ninja", "pirate", "skater", "goth", "robot", "nerd", "bratwurst", "schnitzel","cheerleader","ex-girlfriend","ex-boyfriend","queen","king","necronomicon","magician","warrior","ranger","school boy","school girl","boy","girl","lion","raccoon","dog","cherry","sword","cheese","burrito","taco","chocolate","chips","crisps","fries","cheesus","freedom","book","solider","raider","slug","slime","devil","spider","ghost","truck","device","bullet","death","armor","train","doom","badger","smartphone","drone","dragonfly","ant","football","baseball","carrot","bread","baguette","sushi","mafia","boss","snake","priest","gunner","healer","russian","shark","kraken","crocodile","tentacle","furry","otaku","stoner","rock","hipster","punk","gopnik","stripper","killer","bird","eagle","falcon","pidgeon","money","tree" };
            string[] after = { "from hell","the dankest","of hate","the chosen","the legend","of doom","from mars","on speed","from the deep","of destruction","of distraction","from space","of horror","from the moon","on steroids","out of the dark","of chaos","in beast mode"};
            string outputString = "Monster: ";

            outputString += prefix[rng.Next(prefix.Length)] + " " + second[rng.Next(second.Length)] + " " + after[rng.Next(after.Length)];

            Console.WriteLine(outputString);
            Console.WriteLine(" ");
            var input = Console.ReadKey();
            if(input.Key == ConsoleKey.Enter)
            {
                Main(null);
            }
        }
    }
}
