namespace Trainings26 {
   public class Temparature {
      public int[] CoolerDays (int[] temperatures) {
         int n = temperatures.Length;
         int[] result = new int[n];
         for (int i = 0; i < n; i++) {
            result[i] = 0;
            for (int j = i + 1; j < n; j++) {
               if (temperatures[j] < temperatures[i]) {
                  result[i] = j - i;
                  break;
               }
            }
         }
         return result;
      }
   }
}
