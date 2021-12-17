using System;


namespace RockPaperScissorApp.App
{
    public class Game
    {
        
        
        private int playerPoints = 0;
        private int ComputerPoints = 0;

    public string Summary
    {
        get
        {
            return  $"Player Points: {playerPoints} Computer Points: {computerPoints}";
            
        }
    }


        public void PlayRound()
        {
            //write game here
            int player = 0; 
            int computer = 0;
            Console.WriteLine("Player");
            Console.WriteLine("Computer");

            
            int randomInt = 0;
            Random rnd = new Random();
            RandomInt = rnd.Next(1,4);



            switch (RandomInt)
            {
                case 1: //ROCK
                    Computer = "Rock";
                    Console.WriteLine("Computer Chose Rock");
                    if (player == 1)
                    {
                        Console.WriteLine("It's a Draw!");
                    }
                   
                    if (player == 2)
                    {
                        Console.WriteLine("You Win!");
                            playerPoints++;
                    }
                    
                    if (player == 3)
                    {
                        Console.WriteLine("You lose :(");
                            computerPoints++;
                    }
                    break;

                case 2: //PAPER
                    Computer = "Paper";
                    Console.WriteLine("Computer Chose Paper");
                    if (player == 1)
                    {Console.WriteLine("You lose :(");
                            computerPoints++;
                    }
                     
                    if (player == 2)
                    {
                        Console.WriteLine("It's a Draw!");
                     
                    }
                   
                    if (player == 3)
                    {
                         Console.WriteLine("You Win!");
                            playerPoints++;

                    }
                    break;

                case 3: //SCISSORS
                    Computer = "Scissor";
                    Console.WriteLine("Computer Chose Scissor");
                    if (player == 1)
                    {
                        Console.WriteLine("You Win!");
                            playerPoints++;
                        
                    }
                   
                    if (player == 2)
                    {
                        Console.WriteLine("You lose :(");
                            computerPoints++;
                    }
                    
                    if (player == 3)
                    {
                        Console.WriteLine("It's a Draw!");
                        
                    }
                    break;

                default:
                    Console.WriteLine("Invalide, Try Again");
                    break;
            }
     

            /*switch(player)
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
            }*/
            
            throw new NotImplementedException();
        }
    }




}
