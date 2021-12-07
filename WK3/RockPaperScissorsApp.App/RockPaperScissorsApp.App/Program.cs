//APP to play rock-paper-scissors with the computer\\
//Required Features:
//-play multiple rounds
//-get a summer/record of all the rounds played so far


//Strech goal Features:
//-persistence (sace data somehow, it will remeber past gaem history)
//-play more complex cariants of RPS(RPS+Lizard_spock)
//-logging to help with debuggind the app if something goes wrong


//General we want something simple and fun


namespace RockPaperScissorApp.App
{
    public class Program
    {
        public static void Main()
        {
      
            string player;
            string Computer;
            Random num = new Random();





            Console.WriteLine("Welcome to RockPaperScissors App");


            Console.WriteLine("1.Rock 2.Paper 3.Scissors");
            player = Console.ReadLine();
            player = player.ToUpper();
            var game = new Game();

           

            while (true)
            {
                //player = "";
                //COM = "";
                //while(player != "1" && player != "2" && player != "3" )

                Console.WriteLine();
                Console.WriteLine("Play a round? (y/n)");

                string? input = Console.ReadLine();
                if (input != "y") { break; }

                game.PlayRound();

            }

            switch (num.Next(1, 4))
            {
                case 1:
                    Computer = "Rock";
                    break;

                case 2:
                    Computer = "Paper";
                    break;

                case 3:
                    Computer = "Scissor";
                    break;
            }
            Console.WriteLine("Player:" + player);
            Console.WriteLine("Computer: " + Computer);


            switch(player)
            {
                case "1":
                    if (Computer == "1")
                    {
                        Console.WriteLine("Tie");
                    }
                    else
                    {
                        Console.WriteLine("You win");
                    }
                    break;

                case "2":
                    if(Computer=="2")
                    {
                        Console.WriteLine("");
                    }
                    
                    break;

                case "3":
                    
                    break;
            }

            string summary = game.Summary;
            Console.WriteLine(summary);


            
        }
    }
}