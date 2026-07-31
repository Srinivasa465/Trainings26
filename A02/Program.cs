using static System.Console;
public class A02 {
   static void Main () {
      bool playAgain = true;
      while (playAgain) {
         int randomValue =new Random().Next (1, 101), userValue;
         do {
            while (true) {
               try {
                  Write ("Enter a number between 1 and 100: ");
                  userValue = int.Parse (ReadLine ());
                  if (userValue < 1 || userValue > 100) {
                     WriteLine ("Please enter a number between 1 and 100.");
                     continue;
                  }
                  break;
               } catch (FormatException) {
                  WriteLine ("Please enter numbers only.");
               }
            }
            if (userValue < randomValue) {
               WriteLine ("Your guess is too low.");
            } else if (userValue > randomValue) {
               WriteLine ("Your guess is too high.");
            } else {
               WriteLine ("You guessed correctly!");
            }
         } while (userValue != randomValue);
         Write ("Play again? (Y/N): ");
         string choice = ReadLine ();
         playAgain = choice == "Y" || choice == "y";
      }
   }
}