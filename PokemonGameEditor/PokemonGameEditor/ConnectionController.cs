using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameEditor {
   public class ConnectionController {
      private List<Connection> connections;

      public ConnectionController() {
         connections = new List<>();
      }

      public void reset() {
         connections.Clear();
      }

      public string writeData() {
         // implement
         return "";
      }
   }
}
