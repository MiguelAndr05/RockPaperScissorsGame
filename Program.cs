using System;

class RockPaperScissors
{
    static void Main()
    {
        string userInput;


        do
        {
            Console.WriteLine("What would you like to pick? (Rock, Paper, or Scissors)");
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "rock" || userInput.ToLower() == "paper" || userInput.ToLower() == "scissors")
            {
                
                Random random = new Random();
                int computerChoice = random.Next(1, 4);
                string aiPick = "";

               
                

                Console.WriteLine("Computer Picks: " + aiPick);

                
                
               

                Console.WriteLine("If you would like to play again, please type 'Play'");
                Console.WriteLine("If you would like to stop playing, type 'Exit'");
                userInput = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please pick Rock, Paper, or Scissors.");
            }

        } while (userInput.ToLower() == "play");

        if (userInput.ToLower() == "exit")
        {
            Console.WriteLine("Thanks for playing!");
        
        }
    }
}   
   