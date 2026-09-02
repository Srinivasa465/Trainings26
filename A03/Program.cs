// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2026.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to guess a random number between a range.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace A03;

public class Program {
   static void Main () {
      char[] letters = { 'u', 'x', 'a', 'l', 't', 'n', 'e' };
      var validwords = File.ReadAllLines ("C:/Work/Words.txt").
         Where (w => w.Contains (letters[0]) && w.All (l => letters.Contains (l)) && w.Length >= 4);
      foreach (var word in validwords.OrderByDescending (word => word.Length)) {
         bool containsAllLetters = letters.All (letter => word.Contains (letter));
         int point = word.Length > 4 ? word.Length : 1;
         if (containsAllLetters) {
            point = 15;
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine ($"{point}. {word.ToUpper()}");
            ResetColor ();
         } else WriteLine ($"{point,2}. {word.ToUpper()}");
      }
   }
}

