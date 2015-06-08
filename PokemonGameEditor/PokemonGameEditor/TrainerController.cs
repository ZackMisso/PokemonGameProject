using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameEditor {
   public class TrainerController {
      private List<Trainer> trainers;

      public TrainerController() {
         trainers = new List<Trainer>();
      }
      
      public string writeData() {
         // implement
         return "";
      }

      public void reset() {
         trainers.Clear();
      }
   }
}
