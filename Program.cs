using System;

namespace workspace
{
    class Program
    {
        static void Main(string[] args)
        {
           string guessWord = "elephant";
           string guess = "";
           int guessCount = 0;
           int guessLimit = 5;
           bool outOfGuesses = false;
           
             while(guess != guessWord && !outOfGuesses)
             {
               if(guessCount < guessLimit)
               {
                 Console.Write("Enter guess: ");
                 guess = Console.ReadLine();
                 guessCount++;
               }
               else 
               {
                 outOfGuesses = true;  
               }
             }
            if(outOfGuesses)
            {
              Console.Write("You lose!");
            }
            else 
            {
              Console.Write("You win!");
            }
            Console.ReadLine();
        }
    }
}
