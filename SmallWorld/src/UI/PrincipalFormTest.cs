﻿using SmallWorld.src.Controllers;
using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Interactable.ItemEffects;
using SmallWorld.src.Model.Interactuable;
using SmallWorld.src.Model.Map;
using SmallWorld.src.Model.Terrain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SmallWorld.src.UI
{
    public partial class PrincipalFormTest : Form
    {
        EntityController entityController = EntityController.GetInstance();
        ItemController itemController = ItemController.GetInstance();
        FoodController foodController = FoodController.GetInstance();
        MapController mapController = MapController.GetInstance();
        LandController landController = LandController.GetInstance();
        FormController formController = FormController.GetInstance();
        public PrincipalFormTest()
        {
            InitializeComponent();
            RefreshAllData();
        }

       

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //AdminFormTest adminFormTest = new AdminFormTest();
            //adminFormTest.Show();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            try 
            { 
                ((Entity)cbCurrentPlayerEntities.SelectedItem).Attack((Entity)cbWaitingPlayersEntities.SelectedItem);
                RefreshEntityValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                RefreshEntityValues();
            }
        }

        private void cbSelectMyEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshEntityValues();
            //TODO: hacer que si el jugador cambia de entidad seleccionada, se cambie a la land en donde está.
            /*if (cbCurrentPlayerEntities.SelectedItem is Entity CurrentPlayerEntity)
            cbLands.SelectedItem = mapController.ge*/
        }

        private void cbSelectEntityFromOtherUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshEntityValues();
        }

        
        private void RefreshEntityValues()
        {
            if (cbCurrentPlayerEntities.SelectedItem is Entity selectedCurrentPlayerEntity)
            {
                pbCurrentLifeCurrentPlayerEntity.Value = selectedCurrentPlayerEntity.CurrentLife;
                pbCurrentEnergyCurrentPlayerEntity.Value = selectedCurrentPlayerEntity.CurrentEnergy;
                pbDefensePointsCurrentPlayerEntity.Value = selectedCurrentPlayerEntity.DefensePoints;
                pbAttackPointsCurrentPlayerEntity.Value = selectedCurrentPlayerEntity.AttackPoints;

                lblCurrentLifeCurrentPlayerEntity.Text = Convert.ToString(selectedCurrentPlayerEntity.CurrentLife);
                lblCurrentEnergyCurrentPlayerEntity.Text = Convert.ToString(selectedCurrentPlayerEntity.CurrentEnergy);
                lblDefensePointsCurrentPlayerEntity.Text = Convert.ToString(selectedCurrentPlayerEntity.DefensePoints);
                lblAttackPointsCurrentPlayerEntity.Text = Convert.ToString(selectedCurrentPlayerEntity.AttackPoints);

                CurrentPlayerEntityIsDied(selectedCurrentPlayerEntity);
            }

            if (cbWaitingPlayersEntities.SelectedItem is Entity selectedWaitingPlayerEntity)
            {
                pbCurrentLifeWaitingPlayerEntity.Value = selectedWaitingPlayerEntity.CurrentLife;
                pbCurrentEnergyWaitingPlayerEntity.Value = selectedWaitingPlayerEntity.CurrentEnergy;
                pbDefensePointsWaitingPlayerEntity.Value = selectedWaitingPlayerEntity.DefensePoints;
                pbAttackPointsWaitingPlayerEntity.Value = selectedWaitingPlayerEntity.AttackPoints;

                lblCurrentLifeWaitingPlayerEntity.Text = Convert.ToString(selectedWaitingPlayerEntity.CurrentLife);
                lblCurrentEnergyWaitingPlayerEntity.Text = Convert.ToString(selectedWaitingPlayerEntity.CurrentEnergy);
                lblDefensePointsWaitingPlayerEntity.Text = Convert.ToString(selectedWaitingPlayerEntity.DefensePoints);
                lblAttackPointsWaitingPlayerEntity.Text = Convert.ToString(selectedWaitingPlayerEntity.AttackPoints);

                WaitingPlayerEntityIsDead(selectedWaitingPlayerEntity);
            }
            
            
        }
        
        
        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            RefreshAllData();
        }

        private void RefreshAllData() 
        {
            RefreshEntitiesComboBoxes();
            RefreshEntityValues();
            RefreshItems();
            RefreshFoods();
            //RefreshMap();
        }

        private void RefreshMap()
        {
            formController.RefreshDataSource(bsLands, cbLands, () => mapController.getLands((Map)cbMaps.SelectedItem));
            formController.RefreshDataSource(bsBorderingLands, cbBorderingLands, () => mapController.getBorderingLands((Land)cbLands.SelectedItem));
            formController.RefreshDataSource(bsLands, cbSelectedLand, () => mapController.getLands((Map)cbMaps.SelectedItem));
        }
        private void RefreshFoods()
        {
            formController.RefreshDataSource(bsFoods, cbFood, () => foodController.getFoods());
        }
        private void RefreshItems()
        {
            formController.RefreshDataSource(bsItems, cbItems, () => itemController.getItems());
        }
        private void RefreshEntitiesComboBoxes()
        {
            formController.RefreshDataSource(bsCurrentPlayerEntities, cbCurrentPlayerEntities, () => entityController.getEntities());
            formController.RefreshDataSource(bsWaitingPlayersEntities, cbWaitingPlayersEntities, () => entityController.getEntities());
        }

        private void RefreshPositionables(Land land)
        {
            formController.RefreshDataSource(bsItems, cbItems, () => mapController.GetPositionablesInLand<Item>(land));
            formController.RefreshDataSource(bsFoods, cbFood, () => mapController.GetPositionablesInLand<Food>(land));
            formController.RefreshDataSource(bsCurrentPlayerEntities, cbCurrentPlayerEntities, () => mapController.GetPositionablesInLand<Entity>(land));
            formController.RefreshDataSource(bsWaitingPlayersEntities, cbWaitingPlayersEntities, () => mapController.GetPositionablesInLand<Entity>(land));
        }

        private void PrincipalFormTest_Load(object sender, EventArgs e)
        {
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            ((Entity)cbCurrentPlayerEntities.SelectedItem).Rest();
            RefreshEntityValues();
        }

        private void CurrentPlayerEntityIsDied(Entity selectedCurrentPlayerEntity)
        {
            
                if (selectedCurrentPlayerEntity.DieStatus)
                {
                    btnAttack.Enabled = false;
                    btnInteract.Enabled = false;
                    btnRest.Enabled = false;
                    lblCurrentLifeCurrentPlayerEntity.ForeColor = Color.Red;
                    lblCurrentLifeCurrentPlayerEntity.Text = "Muerto";
                    
                }
                else
                {
                    // Si la entidad está viva, restablece los controles
                    btnAttack.Enabled = true;
                    
                    btnInteract.Enabled = true;
                    btnRest.Enabled = true;
                    lblCurrentLifeCurrentPlayerEntity.ForeColor = Color.Black;
                    lblCurrentLifeCurrentPlayerEntity.Text = selectedCurrentPlayerEntity.CurrentLife.ToString(); // Actualiza el valor de la vida
                    
                }
            
        }

        private void WaitingPlayerEntityIsDead(Entity selectedWaitingPlayerEntity)
        {
            
                if (selectedWaitingPlayerEntity.DieStatus)
                {
                    //TODO: acá se podría pensar en habilitar un botón "comer" para comerse esa entidad muerta.
                    btnAttack.Enabled = false;
                    lblCurrentLifeWaitingPlayerEntity.ForeColor = Color.Red;
                    lblCurrentLifeWaitingPlayerEntity.Text = "Muerto";
                    
                }
                else
                {
                    // Si la entidad está viva, restablece los controles

                    lblCurrentLifeWaitingPlayerEntity.ForeColor = Color.Black;
                    lblCurrentLifeWaitingPlayerEntity.Text = selectedWaitingPlayerEntity.CurrentLife.ToString(); // Actualiza el valor de la vida
                    
                }
            
           
        }

        private void btnInteract_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCurrentPlayerEntities.SelectedItem is Entity selectedCurrentPlayerEntity) { 
                    if (cbItems.SelectedItem is Item item)
                        item.ExecuteEffectStrategy(selectedCurrentPlayerEntity);
                    if (cbFood.SelectedItem is Food food)
                        //selectedCurrentPlayerEntity.Eat(food);
                        entityController.Eat(selectedCurrentPlayerEntity, food);
                }
                RefreshEntityValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                RefreshEntityValues();
            }

        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFood.SelectedIndex = -1;
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbItems.SelectedIndex = -1;
        }

        private void btnGenerateMap_Click(object sender, EventArgs e)
        {
            mapController.GenerateMap();
            formController.RefreshDataSource(bsMaps, cbMaps, () => mapController.GetMaps());
            RefreshMap();
            //btnGenerateMap.Enabled = false;
        }

        private void cbLands_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbLands.SelectedItem is Land land)
            {   
                formController.RefreshDataSource(bsBorderingLands, cbBorderingLands, () => mapController.getBorderingLands(land));
            }
        }

        private void cbMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMap();
        }

        private void cbSelectedLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectedLand.SelectedItem is Land land)
            {
                RefreshPositionables(land);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (cbCurrentPlayerEntities.SelectedItem is Entity entity && cbLands.SelectedItem is Land landOrigin && cbBorderingLands.SelectedItem is Land landDestiny)
            {
                mapController.MoveMovible(landOrigin, landDestiny, entity);
                MessageBox.Show($"{entity} se movió de {landOrigin} a {landDestiny}");
                RefreshPositionables(landOrigin);
            }
        }
    }
}
