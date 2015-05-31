using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameEditor {
   public class Connection {
      private string nameOfLevel;
      private int tileX;
      private int tileY;

      public Connection() {
         nameOfLevel = "";
         tileX = -1;
         tileY = -1;
      }

      // getter methods
      public string getNameOfLevel() { return nameOfLevel; }
      public int getTileX() { return tileX; }
      public int getTileY() { return tileY; }

      // setter methods
      public void setNameOfLevel(string param) { nameOfLevel = param; }
      public void setTileX(int param) { tileX = param; }
      public void setTileY(int param) { tileY = param; }
   }
}