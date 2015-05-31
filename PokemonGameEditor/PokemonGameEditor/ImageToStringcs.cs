using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PokemonGameEditor {
   public class ImageToStringcs {
      private Image image;
      private string name;

      public ImageToString(){
         image = null;
         name = "";
      }

      public ImageToString(Image img,string str){
         image = img;
         str = name;
      }

      // getters
      public Image getImage(){ return image; }
      public string getName(){ return name; }

      // setters
      public void setImage(Image param){ image=param; }
      public void setName(string param) { name=param; }
   }
}
