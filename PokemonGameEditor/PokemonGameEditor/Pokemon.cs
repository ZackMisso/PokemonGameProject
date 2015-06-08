using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGameEditor {
   public class Pokemon {
      private PokemonData reference;
      private int level;
      private int health;
      private int attack;
      private int defense;
      private int specialAttack;
      private int specialDefense;
      private int speed;

      public Pokemon() {
         // implement
      }

      public Pokemon(PokemonData param) {
         reference = param;
         // implement
      }

      public Pokemon(PokemonData param, int lev) {
         reference = param;
         level = lev;
         calculateStatsBasedOnLevel();
      }

      public void calculateStatsBasedOnLevel() {
         //reference.calculateStatsBasedOnLevel(level); // to be implemented
      }

      // getter methods
      public int getLevel() { return level; }
      public int getHealth() { return health; }
      public int getAttack() { return attack; }
      public int getDefense() { return defense; }
      public int getSpecialAttack() { return specialAttack; }
      public int getSpecialDefense() { return specialDefense; }
      public int getSpeed() { return speed; }

      // setter methods
      public void setLevel(int val) { level = val; }
      public void setHealth(int val) { health = val; }
      public void setAttack(int val) { attack = val; }
      public void setDefense(int val) { defense = val; }
      public void setSpecialAttack(int val) { specialAttack = val; }
      public void setSpecialDefense(int val) { specialDefense = val; }
      public void setSpeed(int val) { speed = val; }
   }
}
