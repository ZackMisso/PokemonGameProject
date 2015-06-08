using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameEditor{
   public class Trainer : Displayable{
      private Pokemon[] pokemon;
      //private int tileX;
      //private int tileY;
      //private int direction;

      public Trainer() : base(){
         pokemon = new Pokemon[6];
      }

      // getters
      public Pokemon[] getPokemon() { return pokemon; }
      //public int getTileX() { return tileX; }
      //public int getTileY() { return tileY; }

      // setters
      public void setPokemon(Pokemon[] param) { pokemon = param; }
      //public void setTileX(int param) { tileX = param; }
      //public void setTileY(int param) { tileY = param; }
   }
}
