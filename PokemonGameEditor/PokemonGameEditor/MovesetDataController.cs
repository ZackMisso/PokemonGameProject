using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameEditor {
   public class MovesetDataController {
      private List<MovesetData> moves;

      public MovesetDataController() {
         moves = new List<>();
      }

      public string writeData() {
         // implement
         return "";
      }

      public List<MovesetData> getMoves() { return moves; }
   }
}