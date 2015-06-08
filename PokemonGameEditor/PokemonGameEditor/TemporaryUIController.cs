using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PokemonGameEditor {
   public class TemporaryUIController {
      private Form1 reference;
      private List<ListBox> lboxes;
      private List<Button> buttons;
      private List<PictureBox> pboxes;
      private List<TextBox> tboxes;
      private List<Label> labels;
      private List<NumericUpDown> counters;

      public TemporaryUIController(Form1 param) {
         reference = param;
         lboxes = new List<ListBox>();
         buttons = new List<Button>();
         pboxes = new List<PictureBox>();
         tboxes = new List<TextBox>();
         labels = new List<Label>();
         counters = new List<NumericUpDown>();
      }

      public void reset() {
         for (int i = 0; i < lboxes.Count; i++) {
            reference.Controls.Remove(lboxes[i]);
            reference.getPanel2().Controls.Remove(lboxes[i]);
            reference.getPanel3().Controls.Remove(lboxes[i]);
         }
         for (int i = 0; i < buttons.Count; i++) {
            reference.Controls.Remove(buttons[i]);
            reference.getPanel2().Controls.Remove(buttons[i]);
            reference.getPanel3().Controls.Remove(buttons[i]);
         }
         for (int i = 0; i < pboxes.Count; i++) {
            reference.Controls.Remove(pboxes[i]);
            reference.getPanel2().Controls.Remove(pboxes[i]);
            reference.getPanel3().Controls.Remove(pboxes[i]);
         }
         for (int i = 0; i < tboxes.Count; i++) {
            reference.Controls.Remove(tboxes[i]);
            reference.getPanel2().Controls.Remove(tboxes[i]);
            reference.getPanel3().Controls.Remove(tboxes[i]);
         }
         for (int i = 0; i < labels.Count; i++) {
            reference.Controls.Remove(labels[i]);
            reference.getPanel2().Controls.Remove(labels[i]);
            reference.getPanel3().Controls.Remove(labels[i]);
         }
         for (int i = 0; i < counters.Count; i++) {
            reference.Controls.Remove(counters[i]);
            reference.getPanel2().Controls.Remove(counters[i]);
            reference.getPanel3().Controls.Remove(counters[i]);
         }
         lboxes.Clear();
         buttons.Clear();
         pboxes.Clear();
         tboxes.Clear();
         labels.Clear();
         counters.Clear();
      }

      public void organizeTerrainPictureBoxs(List<PictureBox> images){
         // to be implemented
      }

      public void organizePokemonPictureBoxs(List<PictureBox> images){
         int x = 13;
         int y = 340;
         for(int i = 0;i < images.Count;i++){
            PictureBox box = images[i];
            box.Location = new Point(100 * i, 0);
            box.Visible = true;
            addPictureBox(box);
         }
      }

      public void organizePokemonLabels(List<Label> labels) {
         // to be implemented later
      }

      public void addButton(Button toAdd) {
         buttons.Add(toAdd);
         reference.getPanel3().Controls.Add(toAdd); // change later
         toAdd.BringToFront();
      }

      public void addPictureBox(PictureBox toAdd) {
         pboxes.Add(toAdd);
         toAdd.BringToFront();
         reference.getPanel3().Controls.Add(toAdd);
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

      public PictureBox getClickedPictureBox(int x,int y) {
         for(int i = 0; i < pboxes.Count; i++)
            if (wasClicked(pboxes[i].Location.X,pboxes[i].Location.Y,pboxes[i].Width,pboxes[i].Height,x,y))
               return pboxes[i];
         return null;
      }

      public Button getClickedButton(int x, int y) {
         for(int i = 0; i < buttons.Count; i++)
            if (wasClicked(buttons[i].Location.X, buttons[i].Location.Y, buttons[i].Width, buttons[i].Height, x, y))
               return buttons[i];
         return null;
      }

      public string getTextOfTextBox(string name) {
         for(int i = 0; i < tboxes.Count; i++)
            if(String.Compare(tboxes[i].Name,name) == 0)
               return tboxes[i].Text;
         return "";
      }

      public int getValueOfCounter(string name) {
         for(int i = 0; i < counters.Count; i++)
            if(String.Compare(counters[i].Name,name) == 0)
               return (int)counters[i].Value;
         return 0;
      }

      public string getValueOfListBox(string name){
         for(int i = 0; i < lboxes.Count; i++)
            if(String.Compare(lboxes[i].Name,name) == 0)
               return (string)lboxes[i].SelectedItem;
         return "";
      }
   }
}