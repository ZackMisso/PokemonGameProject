using System;
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
      private enum State { None, AddNPC, AddTrainer, AddBuilding, Save, AddTerrain, AddConnection, AddFightArea, EditingTileMap, EditFightArea};
      private int currentState;
      private bool viewingTileMap;
      //private bool viewingFightArea;
      //private 

      public Form1() {
         InitializeComponent();
         io = new EditorIO();
         movesController = new MovesetDataController();
         pokemonController = new PokemonDataController();
         trainerController = new TrainerController();
         fightAreaController = new FightAreaController();
         npcController = new NPCController();
         imageCache = new GraphicsCache();
         tileMap = new TileMapController();
         terrainMap = new TerrainMap();
         connections = new ConnectionController();
         tempUI = new TemporaryUIController();
         itemController = new ItemDataController();
         currentState = State.None;
         viewindTileMap = false;
         viewingFightArea = false;
      }

      private void reset(){
         trainerController.reset();
         npcController.reset();
         fightAreaController.reset();
         tileMap.reset();
         terrainMap.reset();
         connections.reset();
         changeState(State.None);
         viewingTileMap = false;
         viewingFightArea = false;
         // implement the rest
      }

      //private enum State { None, AddNPC, AddTrainer, AddBuilding, Save, AddTerrain, AddConnection, AddFightArea, EditingTileMap, EditFightArea };
      
      public void changeState(int newState,bool accept){
         if (currentStatus == newState)
            return;
         //tempUI.reset();
         if (currentState != State.None) {
            switch (currentState) {
               case State.None:
                  break;
               case State.AddNPC:
                  switchFromAddNPC(accept);
                  break;
               case State.AddTrainer:
                  switchFromAddTrainer(accept);
                  break;
               case State.AddBuilding:
                  switchFromAddBuilding(accept);
                  break;
               //case State.Save:
               //   switchFromSave(accept);
               //   break;
               case State.AddTerrain:
                  switchFromAddTerrain(accept);
                  break;
               case State.AddConnection:
                  switchFromAddConnection(accept);
                  break;
               case State.AddFightArea:
                  switchFromAddFightArea(accept);
                  break;
               case State.EditingTileMap:
                  switchFromEditingTileMap(accept);
                  break;
               case State.EditFightArea:
                  switchFromEditFightArea(accept);
                  break;
               default:
                  break;
            }
         }
         tempUI.reset();
         switch (newState) {
            case State.None:
               break;
            case State.AddNPC:
               switchToAddNPC();
               break;
            case State.AddTrainer:
               switchToAddTrainer();
               break;
            case State.AddBuilding:
               switchToAddBuilding();
               break;
            //case State.Save:
            //   switchToSave();
            //   break;
            case State.AddTerrain:
               switchToAddTerrain();
               break;
            case State.AddConnection:
               switchToAddConnection();
               break;
            case State.AddFightArea:
               switchToAddFightArea();
               break;
            case State.EditingTileMap:
               switchToEditingTileMap();
               break;
            case State.EditFightArea:
               switchToEditFightArea();
               break;
            default:
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
         // implement
      }

      private void switchFromAddTerrain(bool accept) {
         if (accept) {
            // implement
         }
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

      private void panel1_Paint(object sender, PaintEventArgs e) {
         // implement
      }

      // Open For testing
      private void button1_Click(object sender, EventArgs e) { // Open Level
         OpenFileDialog openLevelBox = new OpenFileDialog();
         openFileBox.Filter = "Level Files|*.lvl"; // maybe change to text files in the future
         openFileBox.FilterIndex = 1;
         openFileBox.Multiselect = false;
         DialogResult userClickedOk = openFileBox.ShowDialog();
         if (userClickedOk == DialogResult.OK) {
            reset();
            io.readLevel(new FileInfo(openFileBox.FileName));
         }
      }

      private void button2_Click(object sender, EventArgs e) {
         // impleemnt
      }

      private void SaveLevelButton_Click(object sender, EventArgs e) {
         //changeState(State.Save, false);
         SaveFileDialog saveFile = new SaveFileDialog();
         if (saveFile.showDialog() == DialogResult.OK)
            io.writeLevel(saveFile.fileName);
      }

      private void AddTrainerButton_Click(object sender, EventArgs e) {
         changeState(State.AddTrainer, false);
      }

      private void NewLevelButton_Click(object sender, EventArgs e) {
         //changeState(State.AddLevel, false);
         reset();
      }

      private void AddTerrainButton_Click(object sender, EventArgs e) {
         changeState(State.AddTerrain, false);
      }

      private void AddConnectionButton_Click(object sender, EventArgs e) {
         changeState(State.AddConnection, false);
      }

      private void AddAreaButton_Click(object sender, EventArgs e) {
         changeState(State.AddFightArea, false);
      }

      private void ViewFightButton_Click(object sender, EventArgs e) {
         // implement
      }

      private void label1_Click(object sender, EventArgs e) {
         // delete
      }

      private void AddNPCButton_Click(object sender, EventArgs e) {
         changeState(State.AddNPC, false);
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
         changeStatus(State.EditTileMap, false);
      }

      private void ViewTileMapButton_Click(object sender, EventArgs e) {
         // implement
      }

      private void AcceptButton_Click(object sender, EventArgs e) {
         changeStatus(State.None, true);
      }

      private void CancelButton_Click(object sender, EventArgs e) {
         changeStatus(State.None, false);
      }

      private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
         // delete
      }
   }
}