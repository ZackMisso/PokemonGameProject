using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameEditor {
   public class UrlController {
      private string urlToBuildings;
      private string urlToPokemon;
      private string urlToTrainers;
      private string urlToTerrain;

      public UrlController() {
         urlToBuildings = "";
         urlToPokemon = "";
         urlToTrainers = "";
         urlToTerrain = "";
      }

      // getter methods
      public string getUrlToBuildings() { return urlToBuildings; }
      public string getUrlToPokemon() { return urlToPokemon; }
      public string getUrlToTrainers() { return urlToTrainers; }
      public string getUrlToTerrain() { return urlToTerrain; }

      // setter methods
      public void setUrlToBuildings(string str) { urlToBuildings = str; }
      public void setUrlToPokemon(string str) { urlToPokemon = str; }
      public void setUrlToTrainers(string str) { urlToTrainers = str; }
      public void setUrlToTerrain(string str) { urlToTerrain = str; }
   }
}
