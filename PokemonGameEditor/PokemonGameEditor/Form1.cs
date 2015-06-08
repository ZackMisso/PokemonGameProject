using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGameEditor {
   public partial class Form1 : Form {
      private EditorIO io;
      private MovesetDataController movesController;
      private PokemonDataController pokemonController;
      private TrainerController trainerController;
      private FightAreaController fightAreaController;
      private NPCController npcController;
      private GraphicsCache imageCache;
      private TileMapController tileMap;
      private TerrainMap terrainMap;
      private ConnectionController connections;
      private TemporaryUIController tempUI;
      private ItemDataController itemController;
      private UrlController urlController;
      private enum State { None, AddNPC, AddTrainer, AddBuilding, Save, AddTerrain, AddConnection, AddFightArea, EditingTileMap, EditFightArea, Test};
      private int currentState;
      private bool viewingTileMap;
      //private bool viewingFightArea;
      //private 

      public Form1() {
         InitializeComponent();
         io = new EditorIO(this);
         movesController = new MovesetDataController();
         pokemonController = new PokemonDataController();
         trainerController = new TrainerController();
         fightAreaController = new FightAreaController();
         npcController = new NPCController();
         imageCache = new GraphicsCache();
         tileMap = new TileMapController();
         terrainMap = new TerrainMap();
         connections = new ConnectionController();
         tempUI = new TemporaryUIController(this);
         itemController = new ItemDataController();
         urlController = new UrlController();
         currentState = (int)State.None;
         viewingTileMap = false;
         //viewingFightArea = false;
      }

      private void reset(){
         trainerController.reset();
         npcController.reset();
         fightAreaController.reset();
         tileMap.reset();
         terrainMap.reset();
         connections.reset();
         changeState((int)State.None,false);
         viewingTileMap = false;
         // viewingFightArea = false;
         // implement the rest
      }

      //private enum State { None, AddNPC, AddTrainer, AddBuilding, Save, AddTerrain, AddConnection, AddFightArea, EditingTileMap, EditFightArea };
      
      public void changeState(int newState,bool accept){
         if (currentState == newState)
            return;
         //tempUI.reset();
         if (currentState != (int)State.None) {
            switch (currentState) {
               case (int)State.None:
                  break;
               case (int)State.AddNPC:
                  switchFromAddNPC(accept);
                  break;
               case (int)State.AddTrainer:
                  switchFromAddTrainer(accept);
                  break;
               case (int)State.AddBuilding:
                  switchFromAddBuilding(accept);
                  break;
               //case State.Save:
               //   switchFromSave(accept);
               //   break;
               case (int)State.AddTerrain:
                  switchFromAddTerrain(accept);
                  break;
               case (int)State.AddConnection:
                  switchFromAddConnection(accept);
                  break;
               case (int)State.AddFightArea:
                  switchFromAddFightArea(accept);
                  break;
               case (int)State.EditingTileMap:
                  switchFromEditingTileMap(accept);
                  break;
               case (int)State.EditFightArea:
                  switchFromEditFightArea(accept);
                  break;
               case (int)State.Test:
                  switchFromTest(accept);
                  break;
               default:
                  break;
            }
         }
         tempUI.reset();
         switch (newState) {
            case (int)State.None:
               break;
            case (int)State.AddNPC:
               switchToAddNPC();
               break;
            case (int)State.AddTrainer:
               switchToAddTrainer();
               break;
            case (int)State.AddBuilding:
               switchToAddBuilding();
               break;
            //case State.Save:
            //   switchToSave();
            //   break;
            case (int)State.AddTerrain:
               switchToAddTerrain();
               break;
            case (int)State.AddConnection:
               switchToAddConnection();
               break;
            case (int)State.AddFightArea:
               switchToAddFightArea();
               break;
            case (int)State.EditingTileMap:
               switchToEditingTileMap();
               break;
            case (int)State.EditFightArea:
               switchToEditFightArea();
               break;
            case (int)State.Test:
               switchToTest();
               break;
            default:
               int temp = 0;
               int num = (int)currentState;
               int num2 = (int)newState;
               int tempe = 0;
               throw new System.InvalidOperationException("No Such State.\n");
               break;
         }
      }

      //private enum State { None, AddNPC, AddTrainer, AddBuilding, Save, AddTerrain, AddConnection, AddFightArea, EditingTileMap, EditFightArea };

      private void switchFromEditFightArea(bool accept) {
         if (accept) {
            // implement
         }
      }

      private void switchToEditFightArea() {
         // implement
      }

      private void switchFromEditingTileMap(bool accept) {
         if (accept) {
            // implement
         }
      }

      private void switchToEditingTileMap() {
         // implement
      }

      private void switchFromAddFightArea(bool accept) {
         if (accept) {
            // implement
         }
      }

      private void switchToAddFightArea() {
         // implement
      }

      private void switchFromAddConnection(bool accept) {
         if (accept) {
            // implement
         }
      }

      private void switchToAddConnection() {
         // implement
      }
      
      private void switchToAddTerrain() {
         List<PictureBox> boxes = new List<PictureBox>();
         if (String.IsNullOrWhiteSpace(urlController.getUrlToTerrain())) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) {
               urlController.setUrlToBuildings(dialog.SelectedPath);
            } else {
               changeState((int)State.None, false);
            }
         }
         string[] files = Directory.GetFiles(urlController.getUrlToTerrain());
         foreach (string file in files){
            if (file.EndsWith(".png")) {
               string name="";
               for (int i = file.Length - 5; i > 0; i--){
                  if(file[i] == '/'){
                     name = file.Substring(i + 1, i + 5 - file.Length);
                  }
               }
               boxes.Add(new PictureBox {
                  Name = name,
                  Size = new Size(96,96)
               });
            boxes[boxes.Count-1].ImageLocation = file;
            }
         }
         //for(int i = 0; i < boxes.Count; i++){
         //   // set location
         tempUI.organizeTerrainPictureBoxs(boxes);
         //}
      }

      private void switchFromAddTerrain(bool accept) {
         // will do nothing
      }

      //private void switchFromSave(bool accept) {
      //   if (accept) {
      //      // implement
      //   }
      //}

      //private void switchToSave() {
      //   // create label
      //   // create textinput for name
      //   // blah blah
      //}

      private void switchFromAddBuilding(bool accept) {
         if (accept) {
            // implement
         }
      }

      private void switchToAddBuilding() {
         // implement
      }

      private void switchFromAddTrainer(bool accept) {
         if (accept) {
            // impelment
         }
      }

      private void switchToAddTrainer() {
         // implement
      }
      
      private void switchFromAddNPC(bool accept) {
         if (accept) {
            // implement
         }
      }

      private void switchToAddNPC() {
         // implement
      }

      private void switchFromTest(bool accept) {
         // implement
      }

      private void switchToTest() {
         List<PictureBox> boxes = new List<PictureBox>();
         if (String.IsNullOrWhiteSpace(urlController.getUrlToBuildings())) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) {
               urlController.setUrlToBuildings(dialog.SelectedPath);
            } else {
               changeState((int)State.None, false);
            }
         }
         string[] files = Directory.GetFiles(urlController.getUrlToBuildings());
         foreach (string file in files){
            if (file.EndsWith(".png")) {
               string name="";
               for (int i = file.Length - 5; i > 0; i--){
                  if(file[i] == '\\'){
                     //Console.WriteLine(file);
                     name = file.Substring(i + 1, (file.Length - 4) - (i + 1));
                     Console.WriteLine(name);
                     i = 0;
                  }
               }
               boxes.Add(new PictureBox {
                  Name = name,
                  Size = new Size(96,96)
               });
               boxes[boxes.Count-1].Image = Image.FromFile(file);
            }
         }
         //for(int i = 0; i < boxes.Count; i++){
         //   // set location
         //boxes[0].Location = new Point(10, 10);
         //boxes[0].Visible = true;
         //this.Controls.Add(boxes[0]);
         tempUI.organizePokemonPictureBoxs(boxes);
         //}
      }

      private void panel1_Paint(object sender, PaintEventArgs e) {
         // implement
      }

      // Open For testing
      private void button1_Click(object sender, EventArgs e) { // Open Level
         OpenFileDialog openLevelBox = new OpenFileDialog();
         openLevelBox.Filter = "Level Files|*.lvl"; // maybe change to text files in the future
         openLevelBox.FilterIndex = 1;
         openLevelBox.Multiselect = false;
         DialogResult userClickedOk = openLevelBox.ShowDialog();
         if (userClickedOk == DialogResult.OK) {
            reset();
            io.readLevel(new FileInfo(openLevelBox.FileName));
         }
      }

      private void button2_Click(object sender, EventArgs e) {
         List<PictureBox> boxes = new List<PictureBox>();
         if (String.IsNullOrWhiteSpace(urlController.getUrlToBuildings())) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) {
               urlController.setUrlToBuildings(dialog.SelectedPath);
            } else {
               changeState((int)State.None, false);
            }
         }
         string[] files = Directory.GetFiles(urlController.getUrlToBuildings());
         foreach (string file in files){
            if (file.EndsWith(".png")) {
               string name="";
               for (int i = file.Length - 5; i > 0; i--){
                  if(file[i] == '/'){
                     name = file.Substring(i + 1, i + 5 - file.Length);
                  }
               }
               boxes.Add(new PictureBox {
                  Name = name,
                  Size = new Size(96,96)
               });
            boxes[boxes.Count-1].ImageLocation = file;
            }
         }
         //for(int i = 0; i < boxes.Count; i++){
         //   // set location
         tempUI.organizePokemonPictureBoxs(boxes);
         //}
      }

      private void SaveLevelButton_Click(object sender, EventArgs e) {
         //changeState(State.Save, false);
         SaveFileDialog saveFile = new SaveFileDialog();
         if (saveFile.ShowDialog() == DialogResult.OK)
            io.writeLevel(saveFile.FileName);
      }

      private void AddTrainerButton_Click(object sender, EventArgs e) {
         changeState((int)State.AddTrainer, false);
      }

      private void NewLevelButton_Click(object sender, EventArgs e) {
         //changeState(State.AddLevel, false);
         reset();
      }

      private void AddTerrainButton_Click(object sender, EventArgs e) {
         changeState((int)State.AddTerrain, false);
      }

      private void AddConnectionButton_Click(object sender, EventArgs e) {
         changeState((int)State.AddConnection, false);
      }

      private void AddAreaButton_Click(object sender, EventArgs e) {
         changeState((int)State.AddFightArea, false);
      }

      private void ViewFightButton_Click(object sender, EventArgs e) {
         // implement
      }

      private void label1_Click(object sender, EventArgs e) {
         // delete
      }

      private void AddNPCButton_Click(object sender, EventArgs e) {
         changeState((int)State.AddNPC, false);
      }

      private void ImportDataButton_Click(object sender, EventArgs e) {
         // implement
      }

      private void panel3_Paint(object sender, PaintEventArgs e) {
         // delete
      }

      private void Form1_Load(object sender, EventArgs e) {
         // delete maybe
      }

      private void panel2_Paint(object sender, PaintEventArgs e) {
         // maybe keep
      }

      private void EditTileMapButton_Click(object sender, EventArgs e) {
         changeState((int)State.EditingTileMap, false);
      }

      private void ViewTileMapButton_Click(object sender, EventArgs e) {
         // implement
      }

      private void AcceptButton_Click(object sender, EventArgs e) {
         changeState((int)State.None, true);
      }

      private void CancelButton_Click(object sender, EventArgs e) {
         changeState((int)State.None, false);
      }

      private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
         // delete
      }

      private void NewScriptButton_Click(object sender, EventArgs e) {
         // to be implemented
      }

      private void SaveScriptButton_Click(object sender, EventArgs e) {
         // to be implemented
      }

      private void DeleteButton_Click(object sender, EventArgs e) {
         // to be implemented
      }

      private void scrollLeftButton_Click(object sender, EventArgs e) {
         // to be implemented
      }

      private void scrollRightButton_Click(object sender, EventArgs e) {
         // to be implemented
      }

      private void ViewScriptsButton_Click(object sender, EventArgs e) {
         // to be implemented
      }

      private void panel3_Paint_1(object sender, PaintEventArgs e) {
         // to be implemented
      }

      private void TestButton_Click(object sender, EventArgs e) {
         changeState((int)State.Test, false);
      }
   }
}