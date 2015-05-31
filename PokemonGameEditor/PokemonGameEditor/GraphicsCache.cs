using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PokemonGameEditor {
   public class GraphicsCache {
      private List<ImageToString> images;

      public GraphicsCache() {
         images = new List<>();
      }

      public void sortByName() {
         // implement
      }

      public void reset() {
         images.Clear();
      }

      // can return null
      public ImageToString findImage(string name) {
         // implement
         return null;
      }
   }
}