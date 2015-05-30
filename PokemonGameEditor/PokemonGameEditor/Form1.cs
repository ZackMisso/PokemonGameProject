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
      private enum State { None, AddNPC, AddTrainer, AddBuilding, Save, AddTerrain, AddConnection, AddFightArea, EditingTileMap};
      //private int currentState;
      private bool viewingTileMap;
      private bool viewingFightArea;
      //private 

      public Form1() {
         InitializeComponent();
         io = new EditorIO();
         movesController = new MovesetDataController();
         pokemonController = new PokemonDataController();
         trainerController = new TrainerController();
         fightAreaController = new FightAreaController();
         npcController = new NPCController();
         State = State.None;
         viewindTileMap = false;
         viewingFightArea = false;
      }

      private void reset(){
         trainerController.reset();
         npcController.reset();
         fightAreaController.reset();
         changeState(State.None);
         // implement the rest
      }

      public void changeState(int newState){
         // implement
      }

      private void panel1_Paint(object sender, PaintEventArgs e) {
         // implement
      }

      private void button1_Click(object sender, EventArgs e) {
         // implement
      }

      private void button2_Click(object sender, EventArgs e) {
         // impleemnt
      }

      private void SaveLevelButton_Click(object sender, EventArgs e) {
         // implement
      }

      private void AddTrainerButton_Click(object sender, EventArgs e) {
         // implement
      }

      private void NewLevelButton_Click(object sender, EventArgs e) {
         // impelement
      }

      private void AddTerrainButton_Click(object sender, EventArgs e) {
         // implement
      }

      private void AddConnectionButton_Click(object sender, EventArgs e) {
         // implement
      }

      private void AddAreaButton_Click(object sender, EventArgs e) {
         // implement
      }

      private void ViewFightButton_Click(object sender, EventArgs e) {
         // implement
      }

      private void label1_Click(object sender, EventArgs e) {
         // delete
      }

      private void AddNPCButton_Click(object sender, EventArgs e) {
         // implement
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
         // implement
      }

      private void ViewTileMapButton_Click(object sender, EventArgs e) {
         // implement
      }

      private void AcceptButton_Click(object sender, EventArgs e) {
         // implement
      }

      private void CancelButton_Click(object sender, EventArgs e) {
         // implement
      }
   }
}