using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameEditor {
   public class NPC {
      //private Image image;
      private string text;
      private int tileX;
      private int tileY;

      public NPC() {
         text = "";
         tileX = 0;
         tileY = 0;
      }

      // getter methods
      public string getText() { return text; }
      public int getTileX() { return tileX; }
      public int getTileY() { return tileY; }

      // setter methods
      public void setText(string param) { text = param; }
      public int setTileX(int param) { tileX = param; }
      public int setTileY(int param) { tileY = param; }
   }
}
