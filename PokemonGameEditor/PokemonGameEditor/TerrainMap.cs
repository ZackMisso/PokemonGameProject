using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameEditor {
   public class TerrainMap {
      List<ImageToInt> terrainMappings;
      private List<List<int>> map;

      public TerrainMap() {
         terrainMappints = new List<>();
         map = new List<>();
      }

      public void reset() {
         map.Clear();
         terrainMappings.Clear();
      }

      public string writeData() {
         // implement
         return "";
      }
   }
}
