// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to guess a random number between a range.
// ------------------------------------------------------------------------------------------------
using static System.Console;
using static System.ConsoleKey;

namespace A02;

public class Program {
   static void Main () {
      while (true) {
         int rNum = new Random ().Next (1, 101), inp;
         do {
            while (true) {
               Write ("Enter a number between 1 and 100: ");
               if (!int.TryParse (ReadLine (), out inp) || inp is < 1 or > 100) {
                  WriteLine ("Please enter a valid number!");
                  continue;
               }
               break;
            }
            WriteLine (inp < rNum ? "Your guess is too low." :
                       inp > rNum ? "Your guess is too high" : "You guessed correctly!");
         } while (inp != rNum);
         for (; ; ) {
            Write ("Play again? (Y/N):");
            var key = ReadKey ().Key;
            WriteLine ();
            if (key is N) Environment.Exit (0);
            if (key is Y) break;
            continue;
         }
      }
   }
}