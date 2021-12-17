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
      
            string player, Computer;
            //int randomInt;

            Console.WriteLine("Welcome to RockPaperScissors App");
            Console.WriteLine("Player pick: 1.Rock 2.Paper 3.Scissors");
            string player = Console.ReadLine();
            //player = player.ToUpper();
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

            

            string summary = game.Summary;
            Console.WriteLine(summary);


            
        }
    }
}