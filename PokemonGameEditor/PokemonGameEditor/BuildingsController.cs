using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameEditor {
   public class BuildingsController {
      private List<string> files;
      private string path;

      public BuildingsController() {
         files = new List<string>();
         path = "";
      }

      // getter methods
      public List<string> getFiles() { return files; }
      public string getPath() { return path; }

      // setter methods
      public void setFiles(List<string> val) { files = val; }
      public void setPath(string str) { path = str; }
   }
}