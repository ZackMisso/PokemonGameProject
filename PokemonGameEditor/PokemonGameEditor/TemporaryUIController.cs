using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGameEditor {
   public class TemporaryUIController {
      private Form1 reference;
      private List<ListBox> lboxes;
      private List<Button> buttons;
      private List<PictureBox> pboxes;
      private List<TextBox> tboxes;
      private List<Label> labels;
      private List<NumericUpDown> counters

      public TemporaryUIController(Form1 param) {
         reference = param;
         lboxes = new List<>();
         buttons = new List<>();
         pboxes = new List<>();
         tboxes = new List<>();
         labels = new List<>();
         counters = new List<>();
      }

      public void reset() {
         for(int i = 0; i < lboxes.Count; i++)
            reference.Controls.Remove(lboxes[i]);
         for (int i = 0; i < buttons.Count; i++)
            reference.Controls.Remove(buttons[i]);
         for (int i = 0; i < pboxes.Count; i++)
            reference.Controls.Remove(pboxes[i]);
         for (int i = 0; i < tboxes.Count; i++)
            reference.Controls.Remove(tboxes[i]);
         for (int i = 0; i < labels.Count; i++)
            reference.Controls.Remove(labels[i]);
         for(int i = 0; i < counters.Count; i++)
            reference.Controls.Remove(counters[i]);
         lboxes.Clear();
         buttons.Clear();
         pboxes.Clear();
         tboxes.Clear();
         labels.Clear();
         counters.Clear();
      }

      public void addButton(Button toAdd) {
         buttons.Add(toAdd);
         reference.Controls.Add(toAdd);
      }

      public void addPictureBox(PictureBox toAdd) {
         pboxes.Add(toAdd);
         reference.Controls.Add(toAdd);
      }

      public void addTextBox(TextBox toAdd) {
         tboxes.Add(toAdd);
         reference.Controls.Add(toAdd);
      }

      public void addLabel(Label toAdd) {
         labels.Add(toAdd);
         reference.Controls.Add(toAdd);
      }

      public void addListBox(ListBox toAdd){
         lboxes.Add(toAdd);
         reference.Controls.Add(toAdd);
      }

      public bool wasClicked(int x, int y,int w,int h,int xx,int yy){
         if(xx > x && xx < x + w)
            if(yy < y && yy > y - h)
               return true;
         return false;
      }

      public PictureBox getClicked(int x,int y) {
         for(int i = 0; i < pboxes.Count; i++)
            if (wasClicked(pboxes[i].Location.x,pboxes[i].Location.y,pboxes[i],Width,pboxes[i].Height,xx,yy))
               return pboxes[i];
         return null;
      }

      public Button getClicked(int x, int y) {
         for(int i = 0; i < tboxes.Count; i++)
            if (wasClicked(tboxes[i].Location.x,tboxes[i].Location.y,tboxes[i],Width,tboxes[i].Height,xx,yy))
               return tboxes[i];
         return null;
      }

      public string getTextOfTextBox(string name) {
         for(int i = 0; i < tboxes.Count; i++)
            if(String.compare(tboxes[i].Name,name) == 0)
               return tboxes[i].Text;
         return "";
      }

      public int getValueOfCounter(string name) {
         for(int i = 0; i < counters.Count; i++)
            if(String.compare(counters[i].Name,name) == 0)
               return counters[i].Value;
         return 0;
      }

      public string getValueOfListBox(string name){
         for(int i = 0; i < lboxes.Count; i++)
            if(String.compare(lboxes[i].Name,name) == 0)
               return lboxes[i].Value;
         return "";
      }
   }
}