using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApp.APP
{
    public class Game
    {
        private List<Record> allRecords = new List<Record>();
        public string PlayerName { get; }
        private string[] RPS = { "Rock", "Paper", "Scissor" };
        // constructor
        public Game(string playerName, List<Record>? allRecords = null)
        {
            this.PlayerName = playerName;
            if (allRecords != null)
            {
                this.allRecords = allRecords;
            }
        }
        public void PlayRound()
        {
            Console.WriteLine("1. Rock\n2. Paper\n3. Scissor");
            string? playerChoice = null;
            int player = 0;
            while (playerChoice == null || playerChoice.Length <= 0)
            {
                Console.Write("What's your choice? ");
                playerChoice = Console.ReadLine();
                bool validchoice = int.TryParse(playerChoice, out player);
                if (!validchoice || (player > 3 && player < 0))
                {
                    Console.WriteLine("Invalid Choice, Try Again!");
                    Console.WriteLine();
                    playerChoice = null;
                    continue;
                }
            }

            if (player < 4 && player > 0)
            {
                Random random = new Random();
                int PCchoice = random.Next(1, 4);
                Console.WriteLine();
                Console.WriteLine($"You choose [{RPS[player - 1]}]");
                Console.WriteLine($"PC gives you a [{RPS[PCchoice - 1]}]");
                // Rock !< Scissor
                if (PCchoice == 1 && player == 3)
                {
                    var record = new Record(DateTime.Now, RPS[PCchoice - 1], RPS[player - 1], "Lose");
                    allRecords.Add(record);
                    Console.WriteLine("You Lose!");
                }
                else if (PCchoice < player)
                {
                    var record = new Record(DateTime.Now, RPS[PCchoice - 1], RPS[player - 1], "Win");
                    allRecords.Add(record);
                    Console.WriteLine("You Win!");
                }
                else if (PCchoice > player)
                {
                    var record = new Record(DateTime.Now, RPS[PCchoice - 1], RPS[player - 1], "Lose");
                    allRecords.Add(record);
                    Console.WriteLine("You Lose!");
                }
                else
                {
                    var record = new Record(DateTime.Now, RPS[PCchoice - 1], RPS[player - 1], "A Tie");
                    allRecords.Add(record);
                    Console.WriteLine("A Tie!");
                }
            }
        }

        public void Summary()
        {
            var summary = new System.Text.StringBuilder();
            summary.AppendLine($"Date\t\t\tComputer\t{PlayerName}\t\tResult");
            summary.AppendLine("---------------------------------------------------------------");
            foreach (var record in allRecords)
            {
                summary.AppendLine($"{record.Date}\t{record.PC}\t\t{record.Player}\t\t{record.result}");
            }
            summary.AppendLine("---------------------------------------------------------------");

            Console.WriteLine(summary.ToString());
        }


    }
}