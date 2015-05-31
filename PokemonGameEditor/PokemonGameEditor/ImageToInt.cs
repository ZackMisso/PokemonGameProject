using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PokemonGameEditor {
   public class ImageToInt {
      private Image image;
      private int id;

      public ImageToInt() {
         image = null;
         id = -1;
      }

      // getter methods
      public Image getImage() { return image; }
      public int getID() { return id; }

      // setter methods
      public void setImage(Image param) { image = param; }
      public void setID(int param) { id = param; }
   }
}
