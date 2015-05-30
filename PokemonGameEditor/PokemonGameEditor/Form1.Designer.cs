﻿namespace PokemonGameEditor {
   partial class Form1 {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.panel1 = new System.Windows.Forms.Panel();
         this.OpenLevelButton = new System.Windows.Forms.Button();
         this.AddTerrainButton = new System.Windows.Forms.Button();
         this.NewBuildingButton = new System.Windows.Forms.Button();
         this.NewLevelButton = new System.Windows.Forms.Button();
         this.AddTrainerButton = new System.Windows.Forms.Button();
         this.SaveLevelButton = new System.Windows.Forms.Button();
         this.panel2 = new System.Windows.Forms.Panel();
         this.AddConnectionButton = new System.Windows.Forms.Button();
         this.AddAreaButton = new System.Windows.Forms.Button();
         this.ViewFightButton = new System.Windows.Forms.Button();
         this.ImportDataButton = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.AddNPCButton = new System.Windows.Forms.Button();
         this.AcceptButton = new System.Windows.Forms.Button();
         this.CancelButton = new System.Windows.Forms.Button();
         this.ViewTileMapButton = new System.Windows.Forms.Button();
         this.EditTileMapButton = new System.Windows.Forms.Button();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel1.Location = new System.Drawing.Point(12, 12);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(480, 320);
         this.panel1.TabIndex = 0;
         this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
         // 
         // OpenLevelButton
         // 
         this.OpenLevelButton.Location = new System.Drawing.Point(498, 12);
         this.OpenLevelButton.Name = "OpenLevelButton";
         this.OpenLevelButton.Size = new System.Drawing.Size(97, 23);
         this.OpenLevelButton.TabIndex = 1;
         this.OpenLevelButton.Text = "Open Level";
         this.OpenLevelButton.UseVisualStyleBackColor = true;
         this.OpenLevelButton.Click += new System.EventHandler(this.button1_Click);
         // 
         // AddTerrainButton
         // 
         this.AddTerrainButton.Location = new System.Drawing.Point(498, 157);
         this.AddTerrainButton.Name = "AddTerrainButton";
         this.AddTerrainButton.Size = new System.Drawing.Size(97, 23);
         this.AddTerrainButton.TabIndex = 2;
         this.AddTerrainButton.Text = "Add Terrain";
         this.AddTerrainButton.UseVisualStyleBackColor = true;
         this.AddTerrainButton.Click += new System.EventHandler(this.AddTerrainButton_Click);
         // 
         // NewBuildingButton
         // 
         this.NewBuildingButton.Location = new System.Drawing.Point(498, 128);
         this.NewBuildingButton.Name = "NewBuildingButton";
         this.NewBuildingButton.Size = new System.Drawing.Size(97, 23);
         this.NewBuildingButton.TabIndex = 3;
         this.NewBuildingButton.Text = "New Building";
         this.NewBuildingButton.UseVisualStyleBackColor = true;
         this.NewBuildingButton.Click += new System.EventHandler(this.button2_Click);
         // 
         // NewLevelButton
         // 
         this.NewLevelButton.Location = new System.Drawing.Point(498, 99);
         this.NewLevelButton.Name = "NewLevelButton";
         this.NewLevelButton.Size = new System.Drawing.Size(97, 23);
         this.NewLevelButton.TabIndex = 4;
         this.NewLevelButton.Text = "New Level";
         this.NewLevelButton.UseVisualStyleBackColor = true;
         this.NewLevelButton.Click += new System.EventHandler(this.NewLevelButton_Click);
         // 
         // AddTrainerButton
         // 
         this.AddTrainerButton.Location = new System.Drawing.Point(498, 70);
         this.AddTrainerButton.Name = "AddTrainerButton";
         this.AddTrainerButton.Size = new System.Drawing.Size(97, 23);
         this.AddTrainerButton.TabIndex = 5;
         this.AddTrainerButton.Text = "Add Trainer";
         this.AddTrainerButton.UseVisualStyleBackColor = true;
         this.AddTrainerButton.Click += new System.EventHandler(this.AddTrainerButton_Click);
         // 
         // SaveLevelButton
         // 
         this.SaveLevelButton.Location = new System.Drawing.Point(498, 41);
         this.SaveLevelButton.Name = "SaveLevelButton";
         this.SaveLevelButton.Size = new System.Drawing.Size(97, 23);
         this.SaveLevelButton.TabIndex = 6;
         this.SaveLevelButton.Text = "Save Level";
         this.SaveLevelButton.UseVisualStyleBackColor = true;
         this.SaveLevelButton.Click += new System.EventHandler(this.SaveLevelButton_Click);
         // 
         // panel2
         // 
         this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel2.Controls.Add(this.CancelButton);
         this.panel2.Controls.Add(this.AcceptButton);
         this.panel2.Location = new System.Drawing.Point(12, 338);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(480, 203);
         this.panel2.TabIndex = 7;
         this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
         // 
         // AddConnectionButton
         // 
         this.AddConnectionButton.Location = new System.Drawing.Point(498, 186);
         this.AddConnectionButton.Name = "AddConnectionButton";
         this.AddConnectionButton.Size = new System.Drawing.Size(97, 23);
         this.AddConnectionButton.TabIndex = 8;
         this.AddConnectionButton.Text = "Add Connection";
         this.AddConnectionButton.UseVisualStyleBackColor = true;
         this.AddConnectionButton.Click += new System.EventHandler(this.AddConnectionButton_Click);
         // 
         // AddAreaButton
         // 
         this.AddAreaButton.Location = new System.Drawing.Point(498, 215);
         this.AddAreaButton.Name = "AddAreaButton";
         this.AddAreaButton.Size = new System.Drawing.Size(97, 23);
         this.AddAreaButton.TabIndex = 9;
         this.AddAreaButton.Text = "Add Fight Area";
         this.AddAreaButton.UseVisualStyleBackColor = true;
         this.AddAreaButton.Click += new System.EventHandler(this.AddAreaButton_Click);
         // 
         // ViewFightButton
         // 
         this.ViewFightButton.Location = new System.Drawing.Point(498, 244);
         this.ViewFightButton.Name = "ViewFightButton";
         this.ViewFightButton.Size = new System.Drawing.Size(97, 27);
         this.ViewFightButton.TabIndex = 10;
         this.ViewFightButton.Text = "View Fight Areas";
         this.ViewFightButton.UseVisualStyleBackColor = true;
         this.ViewFightButton.Click += new System.EventHandler(this.ViewFightButton_Click);
         // 
         // ImportDataButton
         // 
         this.ImportDataButton.Location = new System.Drawing.Point(498, 277);
         this.ImportDataButton.Name = "ImportDataButton";
         this.ImportDataButton.Size = new System.Drawing.Size(97, 23);
         this.ImportDataButton.TabIndex = 11;
         this.ImportDataButton.Text = "Import Data";
         this.ImportDataButton.UseVisualStyleBackColor = true;
         this.ImportDataButton.Click += new System.EventHandler(this.ImportDataButton_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(508, 528);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(70, 13);
         this.label1.TabIndex = 12;
         this.label1.Text = "©FiralStudios";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // AddNPCButton
         // 
         this.AddNPCButton.Location = new System.Drawing.Point(498, 306);
         this.AddNPCButton.Name = "AddNPCButton";
         this.AddNPCButton.Size = new System.Drawing.Size(97, 23);
         this.AddNPCButton.TabIndex = 13;
         this.AddNPCButton.Text = "Add NPC";
         this.AddNPCButton.UseVisualStyleBackColor = true;
         this.AddNPCButton.Click += new System.EventHandler(this.AddNPCButton_Click);
         // 
         // AcceptButton
         // 
         this.AcceptButton.Location = new System.Drawing.Point(99, 175);
         this.AcceptButton.Name = "AcceptButton";
         this.AcceptButton.Size = new System.Drawing.Size(75, 23);
         this.AcceptButton.TabIndex = 14;
         this.AcceptButton.Text = "Accept";
         this.AcceptButton.UseVisualStyleBackColor = true;
         this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
         // 
         // CancelButton
         // 
         this.CancelButton.Location = new System.Drawing.Point(344, 175);
         this.CancelButton.Name = "CancelButton";
         this.CancelButton.Size = new System.Drawing.Size(75, 23);
         this.CancelButton.TabIndex = 15;
         this.CancelButton.Text = "Cancel";
         this.CancelButton.UseVisualStyleBackColor = true;
         this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
         // 
         // ViewTileMapButton
         // 
         this.ViewTileMapButton.Location = new System.Drawing.Point(498, 335);
         this.ViewTileMapButton.Name = "ViewTileMapButton";
         this.ViewTileMapButton.Size = new System.Drawing.Size(97, 23);
         this.ViewTileMapButton.TabIndex = 14;
         this.ViewTileMapButton.Text = "View Tile Map";
         this.ViewTileMapButton.UseVisualStyleBackColor = true;
         this.ViewTileMapButton.Click += new System.EventHandler(this.ViewTileMapButton_Click);
         // 
         // EditTileMapButton
         // 
         this.EditTileMapButton.Location = new System.Drawing.Point(498, 364);
         this.EditTileMapButton.Name = "EditTileMapButton";
         this.EditTileMapButton.Size = new System.Drawing.Size(97, 23);
         this.EditTileMapButton.TabIndex = 15;
         this.EditTileMapButton.Text = "Edit Tile Map";
         this.EditTileMapButton.UseVisualStyleBackColor = true;
         this.EditTileMapButton.Click += new System.EventHandler(this.EditTileMapButton_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(601, 550);
         this.Controls.Add(this.EditTileMapButton);
         this.Controls.Add(this.ViewTileMapButton);
         this.Controls.Add(this.AddNPCButton);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.ImportDataButton);
         this.Controls.Add(this.ViewFightButton);
         this.Controls.Add(this.AddAreaButton);
         this.Controls.Add(this.AddConnectionButton);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.SaveLevelButton);
         this.Controls.Add(this.AddTrainerButton);
         this.Controls.Add(this.NewLevelButton);
         this.Controls.Add(this.NewBuildingButton);
         this.Controls.Add(this.AddTerrainButton);
         this.Controls.Add(this.OpenLevelButton);
         this.Controls.Add(this.panel1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.panel2.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button OpenLevelButton;
      private System.Windows.Forms.Button AddTerrainButton;
      private System.Windows.Forms.Button NewBuildingButton;
      private System.Windows.Forms.Button NewLevelButton;
      private System.Windows.Forms.Button AddTrainerButton;
      private System.Windows.Forms.Button SaveLevelButton;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Button AddConnectionButton;
      private System.Windows.Forms.Button AddAreaButton;
      private System.Windows.Forms.Button ViewFightButton;
      private System.Windows.Forms.Button ImportDataButton;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button AddNPCButton;
      private System.Windows.Forms.Button CancelButton;
      private System.Windows.Forms.Button AcceptButton;
      private System.Windows.Forms.Button ViewTileMapButton;
      private System.Windows.Forms.Button EditTileMapButton;
   }
}

