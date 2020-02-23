using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaMeBotNS;
using SC2API_CSharp;
using SC2APIProtocol;

namespace ExampleBot
{
    class Program
    {
        // Settings for your bot.
        private static Bot bot = new LaMeBot();
        private static Race race = Race.Terran;
        public static GameConnection gc;

        // Settings for single player mode.
        private static string mapName = @"TritonLE.SC2Map";
        private static Race opponentRace = Race.Random;
        private static Difficulty opponentDifficulty = Difficulty.VeryHard;

        /* The main entry point for the bot.
         * This will start the Stacraft 2 instance and connect to it.
         * The program can run in single player mode against the standard Blizzard AI, or it can be run against other bots through the ladder.
         */
        static void Main(string[] args)
        {

            gc = new GameConnection();
            if (args.Length == 0)
            {
                
                gc.RunSinglePlayer(bot, mapName, race, opponentRace, opponentDifficulty).Wait();
            }
               
            else
                new GameConnection().RunLadder(bot, race, args).Wait();
        }
    }
}
