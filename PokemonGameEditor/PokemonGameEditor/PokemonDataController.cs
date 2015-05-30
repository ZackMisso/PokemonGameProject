using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameEditor {
   public class PokemonDataController {
      private List<PokemonData> pokemons;

      public PokemonDataController() {
         pokemons=new List<>();
      }

      public string writeData() {
         // implement
         return "";
      }

      public List<PokemonData> getData() { return pokemons; }
   }
}