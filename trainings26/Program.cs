using Trainings26;

namespace trainings26;

class Program {
   static void Main (string[] args) {
      Temparature br = new Temparature ();
      int[] temperatures = { 30, 31, 29, 32, 28, 27, 30, 25 };
      Console.WriteLine (string.Join (", ", br.CoolerDays (temperatures)));
   }
}
