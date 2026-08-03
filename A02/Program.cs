// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to guess a random number between a range.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace A02;

public class Program {
   static void Main () {
      bool playAgain = true;
      while (playAgain) {
         int randomValue = new Random ().Next (1, 101), userValue;
         do {
            while (true) {
               Write ("Enter a number between 1 and 100: ");
               if (!int.TryParse (ReadLine (), out userValue) || userValue < 1 || userValue > 100) {
                  WriteLine ("Please enter a valid number!");
                  continue;
               }
               break;
            }
            WriteLine (userValue < randomValue ? "Your guess is too low." :
               userValue > randomValue ? "Your guess is too high" : "You guessed corrctly!");
         } while (userValue != randomValue);
         bool validInput = false;
         while (!validInput) {
            Write ("Play again? (Y/N):");
            ConsoleKeyInfo key = ReadKey ();
            WriteLine ();
            if (key.Key == ConsoleKey.Y) {
               playAgain = true;
               validInput = true;
            } else if (key.Key == ConsoleKey.N) {
               playAgain = false;
               validInput = true;
            } else {
               WriteLine ("Invalid input, please press Y/N");
            }
         }
      }
   }
}