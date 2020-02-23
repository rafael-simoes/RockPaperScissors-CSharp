using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock Paper Scissors");
          

                Console.Write("Your Choice? (R P S)");
                string user_choice = Console.ReadLine();

                string[] hipothesis = { "R", "P", "S" };

                string ai_choice = hipothesis[new Random().Next(0, hipothesis.Length)];


                switch (user_choice)
                {
                    case "P":
                    case "p":
                        if (ai_choice == "S")
                            Console.WriteLine("You: Paper  AI: Scissors. You Lose.");
                        else if (ai_choice == "R") Console.WriteLine("You: Paper  AI: Rock You Win.");
                        else Console.WriteLine("You: Paper  AI: Paper It's a tie!");
                        break;

                    case "S":
                    case "s":
                        if (ai_choice == "R")
                            Console.WriteLine("You: Scissors  AI: Rock. You Lose.");
                        else if (ai_choice == "P") Console.WriteLine("You: Scissors  AI: Paper You Win.");
                        else Console.WriteLine("You: Scissors  AI: Scissors It's a tie!");
                        break;

                    case "R":
                    case "r":
                        if (ai_choice == "P")
                            Console.WriteLine("You: Rock  AI: Paper. You Lose.");
                        else if (ai_choice == "S") Console.WriteLine("You: Scissors  AI: Paper You Win.");
                        else Console.WriteLine("You: Rock  AI: Rock It's a tie!");
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please pick R P or S");
                        break;

                }
            
          
        }
    }
}
