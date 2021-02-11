using System;

namespace workspace
{
    class Program
    {
        static void Main(string[] args)
        {
           string guessWord = "elephant";
           string guess = "";
           
             while(guess != guessWord)
             {
               Console.Write("Enter guess: ");
               guess = Console.ReadLine();
             }
            
            Console.Write("You win!");
          
            Console.ReadLine();
        }
    }
}
