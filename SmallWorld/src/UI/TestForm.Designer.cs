﻿namespace SmallWorld.src.UI
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCreateEntity = new System.Windows.Forms.Button();
            this.cbKingdom = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDiet = new System.Windows.Forms.ComboBox();
            this.cbHabitat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAttack = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDefense = new System.Windows.Forms.TrackBar();
            this.lblAttackPoints = new System.Windows.Forms.Label();
            this.lblDefensePoints = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEntities = new System.Windows.Forms.DataGridView();
            this.cbSelectAttackEntity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSelectDefenseEntity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.dgvWarResults = new System.Windows.Forms.DataGridView();
            this.btnCreateMap = new System.Windows.Forms.Button();
            this.btnShowMap = new System.Windows.Forms.Button();
            this.panelMap = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iKingdomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vegetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vegetableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vegetableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iKingdomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateEntity
            // 
            this.btnCreateEntity.Location = new System.Drawing.Point(58, 190);
            this.btnCreateEntity.Name = "btnCreateEntity";
            this.btnCreateEntity.Size = new System.Drawing.Size(197, 23);
            this.btnCreateEntity.TabIndex = 0;
            this.btnCreateEntity.Text = "Crear Entidad";
            this.btnCreateEntity.UseVisualStyleBackColor = true;
            this.btnCreateEntity.Click += new System.EventHandler(this.btnCreateEntity_Click);
            // 
            // cbKingdom
            // 
            this.cbKingdom.FormattingEnabled = true;
            this.cbKingdom.Location = new System.Drawing.Point(232, 76);
            this.cbKingdom.Name = "cbKingdom";
            this.cbKingdom.Size = new System.Drawing.Size(121, 21);
            this.cbKingdom.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Entidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dieta";
            // 
            // cbDiet
            // 
            this.cbDiet.FormattingEnabled = true;
            this.cbDiet.Location = new System.Drawing.Point(462, 75);
            this.cbDiet.Name = "cbDiet";
            this.cbDiet.Size = new System.Drawing.Size(121, 21);
            this.cbDiet.TabIndex = 7;
            // 
            // cbHabitat
            // 
            this.cbHabitat.FormattingEnabled = true;
            this.cbHabitat.Location = new System.Drawing.Point(462, 18);
            this.cbHabitat.Name = "cbHabitat";
            this.cbHabitat.Size = new System.Drawing.Size(121, 21);
            this.cbHabitat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Habitat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fuerza de Ataque";
            // 
            // tbAttack
            // 
            this.tbAttack.LargeChange = 10;
            this.tbAttack.Location = new System.Drawing.Point(230, 139);
            this.tbAttack.Maximum = 90;
            this.tbAttack.Minimum = 10;
            this.tbAttack.Name = "tbAttack";
            this.tbAttack.Size = new System.Drawing.Size(104, 45);
            this.tbAttack.SmallChange = 10;
            this.tbAttack.TabIndex = 11;
            this.tbAttack.Value = 10;
            this.tbAttack.Scroll += new System.EventHandler(this.tbAttack_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Escudo de Defensa";
            // 
            // tbDefense
            // 
            this.tbDefense.Enabled = false;
            this.tbDefense.LargeChange = 10;
            this.tbDefense.Location = new System.Drawing.Point(538, 139);
            this.tbDefense.Maximum = 100;
            this.tbDefense.Name = "tbDefense";
            this.tbDefense.Size = new System.Drawing.Size(104, 45);
            this.tbDefense.SmallChange = 10;
            this.tbDefense.TabIndex = 13;
            this.tbDefense.Value = 90;
            // 
            // lblAttackPoints
            // 
            this.lblAttackPoints.AutoSize = true;
            this.lblAttackPoints.Location = new System.Drawing.Point(136, 156);
            this.lblAttackPoints.Name = "lblAttackPoints";
            this.lblAttackPoints.Size = new System.Drawing.Size(31, 13);
            this.lblAttackPoints.TabIndex = 14;
            this.lblAttackPoints.Text = "Valor";
            // 
            // lblDefensePoints
            // 
            this.lblDefensePoints.AutoSize = true;
            this.lblDefensePoints.Location = new System.Drawing.Point(416, 156);
            this.lblDefensePoints.Name = "lblDefensePoints";
            this.lblDefensePoints.Size = new System.Drawing.Size(31, 13);
            this.lblDefensePoints.TabIndex = 15;
            this.lblDefensePoints.Text = "Valor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Mostrar Entidades Por Consola";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEntities
            // 
            this.dgvEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntities.Location = new System.Drawing.Point(282, 190);
            this.dgvEntities.Name = "dgvEntities";
            this.dgvEntities.Size = new System.Drawing.Size(416, 150);
            this.dgvEntities.TabIndex = 18;
            // 
            // cbSelectAttackEntity
            // 
            this.cbSelectAttackEntity.FormattingEnabled = true;
            this.cbSelectAttackEntity.Location = new System.Drawing.Point(58, 376);
            this.cbSelectAttackEntity.Name = "cbSelectAttackEntity";
            this.cbSelectAttackEntity.Size = new System.Drawing.Size(121, 21);
            this.cbSelectAttackEntity.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Seleccionar Entidad Atacante";
            // 
            // cbSelectDefenseEntity
            // 
            this.cbSelectDefenseEntity.FormattingEnabled = true;
            this.cbSelectDefenseEntity.Location = new System.Drawing.Point(247, 376);
            this.cbSelectDefenseEntity.Name = "cbSelectDefenseEntity";
            this.cbSelectDefenseEntity.Size = new System.Drawing.Size(121, 21);
            this.cbSelectDefenseEntity.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Seleccionar Entidad a Atacar";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(421, 376);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 23;
            this.btnAttack.Text = "Atacar";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // dgvWarResults
            // 
            this.dgvWarResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarResults.Location = new System.Drawing.Point(515, 351);
            this.dgvWarResults.Name = "dgvWarResults";
            this.dgvWarResults.Size = new System.Drawing.Size(279, 150);
            this.dgvWarResults.TabIndex = 24;
            // 
            // btnCreateMap
            // 
            this.btnCreateMap.Location = new System.Drawing.Point(58, 459);
            this.btnCreateMap.Name = "btnCreateMap";
            this.btnCreateMap.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMap.TabIndex = 26;
            this.btnCreateMap.Text = "Crear Mapa";
            this.btnCreateMap.UseVisualStyleBackColor = true;
            this.btnCreateMap.Click += new System.EventHandler(this.btnCreateMap_Click);
            // 
            // btnShowMap
            // 
            this.btnShowMap.Location = new System.Drawing.Point(161, 459);
            this.btnShowMap.Name = "btnShowMap";
            this.btnShowMap.Size = new System.Drawing.Size(112, 23);
            this.btnShowMap.TabIndex = 27;
            this.btnShowMap.Text = "Mostrar Mapa";
            this.btnShowMap.UseVisualStyleBackColor = true;
            this.btnShowMap.Click += new System.EventHandler(this.btnShowMap_Click);
            // 
            // panelMap
            // 
            this.panelMap.Location = new System.Drawing.Point(282, 507);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(534, 182);
            this.panelMap.TabIndex = 28;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::SmallWorld.Properties.Resources.HexagonEarth;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(301, 376);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(121, 587);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 587);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // iKingdomBindingSource
            // 
            this.iKingdomBindingSource.DataSource = typeof(SmallWorld.src.Interfaces.IKingdom);
            // 
            // vegetableBindingSource
            // 
            this.vegetableBindingSource.DataSource = typeof(SmallWorld.src.Model.Reino.Vegetable);
            // 
            // vegetableBindingSource1
            // 
            this.vegetableBindingSource1.DataSource = typeof(SmallWorld.src.Model.Reino.Vegetable);
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(SmallWorld.src.Model.Reino.Animal);
            // 
            // vegetableBindingSource2
            // 
            this.vegetableBindingSource2.DataSource = typeof(SmallWorld.src.Model.Reino.Vegetable);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 701);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.btnShowMap);
            this.Controls.Add(this.btnCreateMap);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvWarResults);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbSelectDefenseEntity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSelectAttackEntity);
            this.Controls.Add(this.dgvEntities);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDefensePoints);
            this.Controls.Add(this.lblAttackPoints);
            this.Controls.Add(this.tbDefense);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAttack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHabitat);
            this.Controls.Add(this.cbDiet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbKingdom);
            this.Controls.Add(this.btnCreateEntity);
            this.Name = "TestForm";
            this.Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)(this.tbAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iKingdomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetableBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEntity;
        private System.Windows.Forms.ComboBox cbKingdom;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDiet;
        private System.Windows.Forms.ComboBox cbHabitat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbAttack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tbDefense;
        private System.Windows.Forms.Label lblAttackPoints;
        private System.Windows.Forms.Label lblDefensePoints;
        private System.Windows.Forms.BindingSource vegetableBindingSource;
        private System.Windows.Forms.BindingSource vegetableBindingSource1;
        private System.Windows.Forms.BindingSource iKingdomBindingSource;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.BindingSource vegetableBindingSource2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvEntities;
        private System.Windows.Forms.ComboBox cbSelectAttackEntity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSelectDefenseEntity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.DataGridView dgvWarResults;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCreateMap;
        private System.Windows.Forms.Button btnShowMap;
        private System.Windows.Forms.Panel panelMap;
    }
}