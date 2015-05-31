using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PokemonGameEditor {
   public class Displayable {
      private Image image;
      private int tileX;
      private int tileY;
      private enum Direction = {North, South, East, West};
      private int direction;

      public Displayable(){
         tileX = 0;
         tileY = 0;
         direction = Direction.South;
      }

      // getter methods
      public Image getImage(){return image;}
      public int getTileX(){return tileX;}
      public int getTileY(){return tileY;}
      public int getDirection(){return Direction;}

      // setter methods
      public void setImage(Image param){image=param;}
      public void setTileX(int param){tileX=param;}
      public void setTileY(int param){tileY=param;}
      public void setDirection(int param){direction=param;}
   }
}