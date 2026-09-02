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
      var validwords = File.ReadAllLines ("C:/Work/Words.txt")
         .Where (w => w.Length >= 4 && w.Contains (letters[0]) && w.All (l => letters.Contains (l)));
      var scoredWords = validwords.Select (word => {
         bool containsAllLetters = letters.All (letter => word.Contains (letter));
         int point = word.Length > 4 ? word.Length : 1;
         if (containsAllLetters)
            point += 7;
         return (word, point, containsAllLetters);
      });
      foreach (var item in scoredWords.OrderByDescending (x => x.point).ThenBy (x => x.word)) {
         if (item.containsAllLetters) {
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine ($"{item.point,2}. {item.word.ToUpper ()}");
            ResetColor ();
         } else {
            WriteLine ($"{item.point,2}. {item.word.ToUpper ()}");
         }
      }
   }
}