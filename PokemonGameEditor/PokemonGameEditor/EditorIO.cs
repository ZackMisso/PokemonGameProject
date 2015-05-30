using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PokemonGameEditor {
   public class EditorIO {
      private Form1 reference;
      private FileInfo pokemonStats;
      private FileInfo moveSetStats;
      
      public EditorIO(Form1 param){
         reference=param;
      }

      public void writeLevel() {
         // implement
      }

      public void readLevel(FileInfo file) {
         // implement
      }

      public void readData(FileInfo file) {
         // implement
      }
   }
}