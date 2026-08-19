using System;
using System.Collections.Generic;
using System.Text;

namespace Trainings26 {
   public class Balancedbracketchecker {
      public bool Brackets (string str) {
         if(str =="(" || str == "[" || str == "{") {
            return true;
         } else {
            return false;
         }
      }
   }
}
