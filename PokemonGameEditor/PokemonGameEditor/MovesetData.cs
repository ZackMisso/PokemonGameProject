using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace PokemonGameEditor {
   public class MovesetData {
      private string name;
      private string type;
      private int power;
      private int accuracy;
      private int ap;

      public MovesetData() {
         // to be implemetned
      }

      public void loadMoveData(ExcelPackage pkg, int row) {
         // to be implement
      }

      // getter methods
      public string getName() { return name; }
      public string getType() { return type; }
      public int getPower() { return power; }
      public int getAccuracy() { return accuracy; }
      public int getAp() { return ap; }

      // setter methods
      public void setName(string val) { name = val; }
      public void setType(string val) { type = val; }
      public void setPower(int val) { power = val; }
      public void setAccuracy(int val) { accuracy = val; }
      public void setAp(int val) { ap = val; }
   }
}