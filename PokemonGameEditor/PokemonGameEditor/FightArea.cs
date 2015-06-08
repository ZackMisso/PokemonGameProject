using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameEditor {
   public class FightArea {
      private List<PokemonData> pokemonInArea;
      private List<List<int>> areaMap;

      public FightArea() {
         pokemonInArea = new List<PokemonData>();
         areaMap = new List<List<int>>();
      }

      public void addMapLocation(int r, int c) {
         // implement
      }
   }
}