using System;


namespace RockPaperScissorApp.App
{
    public class Game
    {
        private static string pick = "Rock, Paper, Scissor" ;  

        public string Summary
        {
            get
            {
                return $"Player Points: {playerPoints} Computer Points: {computerPoints}";

            }
        }

        public string Computer { get => computer; set => computer = value; }
   
        private string? player; 
        private string computer;
        private int playerPoints = 0;
        private int computerPoints = 0;


        public void PlayRound()
        {
            //write game here
            int playerScore = 0;
            int computerScore = 0;
           

            int randomInt;
            Random rnd = new Random();
            randomInt = rnd.Next(1, 4);
            while (playerScore < 3 && computerScore < 3)
            {

                switch (randomInt)
                {


                    //Computer
                    case 1: //ROCK
                        Computer = "Rock";
                        Console.WriteLine("Computer Chose Rock");
                        if (player == "Rock")
                        {
                            Console.WriteLine("It's a Draw!");
                        }

                        if (player == "Paper")
                        {
                            Console.WriteLine("You Win!");
                            playerPoints++;
                        }

                        if (player == "Scissors")
                        {
                            Console.WriteLine("You lose :(");
                            computerPoints++;
                        }
                        break;

                    case 2: //PAPER
                        Computer = "Paper";
                        Console.WriteLine("Computer Chose Paper");
                        if (player == "Rock")
                        {
                            Console.WriteLine("You lose :(");
                            computerPoints++;
                        }

                        if (player == "Paper")
                        {
                            Console.WriteLine("It's a Draw!");

                        }

                        if (player == "Scissors")
                        {
                            Console.WriteLine("You Win!");
                            playerPoints++;

                        }
                        break;

                    case 3: //SCISSORS
                        Computer = "Scissor";
                        Console.WriteLine("Computer Chose Scissor");
                        if (player == "Rock")
                        {
                            Console.WriteLine("You Win!");
                            playerPoints++;

                        }

                        if (player == "Paper")
                        {
                            Console.WriteLine("You lose :(");
                            computerPoints++;
                        }

                        if (player == "Scissors")
                        {
                            Console.WriteLine("It's a Draw!");

                        }
                        break;

                    default:
                        Console.WriteLine("Invalide, Try Again");
                        break;
                }
                //determine who wins
                if (playerScore == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (computerScore == 3)
                {
                    Console.WriteLine("Computer WON!");
                }
                else
                {

                }

                throw new NotImplementedException();
            }
        }




    }
}
