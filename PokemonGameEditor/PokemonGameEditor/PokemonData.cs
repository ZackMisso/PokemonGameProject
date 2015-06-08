using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace PokemonGameEditor {
   public class PokemonData {
      private string name;
      private string type;
      private int baseHealth;
      private int baseAttack;
      private int baseDefense;
      private int baseSpAttack;
      private int baseSpDefense;
      private int baseSpeed;
      private int maxFullHealth;
      private int maxFullAttack;
      private int maxFullDefense;
      private int maxFullSpAttack;
      private int maxFullSpDefense;
      private int maxFullSpeed;
      private int minFullHealth;
      private int minFullAttack;
      private int minFullDefense;
      private int minFullSpAttack;
      private int minFullSpDefense;
      private int minFullSpeed;

      public PokemonData() {
         // implement
      }

      public void loadPokemonData(ExcelPackage pkg, int row) {
         // to be implement
      }

      // getters
      public string getName() { return name; }
      public string getType() { return type; }
      public int getBaseHealth() { return baseHealth; }
      public int getBaseAttack() { return baseAttack; }
      public int getBaseDefense() { return baseDefense; }
      public int getBaseSpAttack() { return baseSpAttack; }
      public int getBaseSpDefense() { return baseSpDefense; }
      public int getBaseSpeed() { return baseSpeed; }
      public int getMaxFullHealth() { return maxFullHealth; }
      public int getMaxFullAttack() { return maxFullAttack; }
      public int getMaxFullDefense() { return maxFullDefense; }
      public int getMaxFullSpAttack() { return maxFullSpAttack; }
      public int getMaxFullSpDefense() { return maxFullSpDefense; }
      public int getMaxFullSpeed() { return maxFullSpeed; }
      public int getMinFullHealth() { return minFullHealth; }
      public int getMinFullAttack() { return minFullAttack; }
      public int getMinFullDefense() { return minFullDefense; }
      public int getMinFullSpAttack() { return minFullSpAttack; }
      public int getMinFullSpDefense() { return minFullSpDefense; }
      public int getMinFullSpeed() { return minFullSpeed; }

      // setters
      public void setName(string val) { name = val; }
      public void setType(string val) { type = val; }
      public void setBaseHealth(int val) { baseHealth = val; }
      public void setBaseAttack(int val) { baseAttack = val; }
      public void setBaseDefense(int val) { baseDefense = val; }
      public void setBaseSpAttack(int val) { baseSpAttack = val; }
      public void setBaseSpDefense(int val) { baseSpDefense = val; }
      public void setBaseSpeed(int val) { baseSpeed = val; }
      public void setMaxFullHealth(int val) { maxFullHealth = val; }
      public void setMaxFullAttack(int val) { maxFullAttack = val; }
      public void setMaxFullDefense(int val) { maxFullDefense = val; }
      public void setMaxFullSpAttack(int val) { maxFullSpAttack = val; }
      public void setMaxFullSpDefense(int val) { maxFullSpDefense = val; }
      public void setMaxFullSpeed(int val) { maxFullSpeed = val; }
      public void setMinFullHealth(int val) { minFullHealth = val; }
      public void setMinFullAttack(int val) { minFullAttack = val; }
      public void setMinFullDefense(int val) { minFullDefense = val; }
      public void setMinFullSpAttack(int val) { minFullSpAttack = val; }
      public void setMinFullSpDefense(int val) { minFullSpDefense = val; }
      public void setMinFullSpeed(int val) { minFullSpeed = val; }
   }
}
