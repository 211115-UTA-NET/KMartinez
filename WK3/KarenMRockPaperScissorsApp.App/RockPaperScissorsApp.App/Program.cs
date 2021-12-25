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
      

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RockPaperScissors App");
            //Enter player name

            Console.WriteLine("Player pick: Rock, Paper, Scissors");
            Console.WriteLine();
        

            var game = new Game();
            game.PlayRound();
            Console.WriteLine("Play a round? (y/n)");


            string? input;

            while (true)
            {
         
                input = Console.ReadLine();
                if (input != "y") { break; }

                game.PlayRound();

            }

            

            string summary = game.Summary;
            Console.WriteLine(summary);


            
        }
    }
}