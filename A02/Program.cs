// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to guess a random number between a range.
// ------------------------------------------------------------------------------------------------
using static System.Console;
public class A02 {
   static void Main () {
      bool playAgain = true;
      while (playAgain) {
         int randomValue = new Random ().Next (1, 101), userValue;
         do {
            while (true) {
               Write ("Enter a number between 1 and 100: ");
               if (!int.TryParse (Console.ReadLine (), out userValue)) {
                  WriteLine ("Please enter a valid number:");
                  continue;
               }
               if (userValue < 1 || userValue > 100) {
                  WriteLine ("Please enter a number between 1 and 100.");
                  continue;
               }
               break;
            }
            switch (userValue) {
               case < 101 when userValue < randomValue:
                  WriteLine ("Your guess is too low.");
                  break;
               case <= 100 when userValue > randomValue:
                  WriteLine ("Your guess is too high.");
                  break;
               default:
                  WriteLine ("You guessed correctly!");
                  break;
            }
         } while (userValue != randomValue);
         WriteLine ("Play again? (Y/N): ");
         ConsoleKeyInfo key = ReadKey ();
         WriteLine ();
         playAgain = key.Key == ConsoleKey.Y;
      }
   }
}