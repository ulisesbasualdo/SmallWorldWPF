﻿using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using SmallWorld.src.Model.Dieta;
using SmallWorld.src.Model.Interactuable;
using SmallWorld.src.Model.Reino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SmallWorld.src.Controllers
{
    internal class EntityController
    {
        private static EntityController instance;
        private readonly List<Entity> Entities = new List<Entity>();
        private EntityController() { }

        //private readonly static EntityController EntitiesController = new EntityController();

        public static EntityController GetInstance()
        {
            if (instance == null)
            {
                instance = new EntityController();
            }
            return instance;
        }

        


        public void AddEntity(IKingdom kingdom, string name, IDiet diet, IHabitat habitat, int atkPonints, int defPoints, bool range, int maxLife, int maxEnergy, int defenseShield)
        {
            Entity EntityToAdd = new Entity(kingdom, name, diet, habitat, atkPonints, defPoints, range, maxLife, maxEnergy, defenseShield);
            Entities.Add(EntityToAdd);
        }
        

        public List<Entity> getEntities()
        {
            return Entities;
        }
        public List<Entity> getEntitiesCopy1()
        {
            List<Entity> ListForComboBox1 = new List<Entity>(Entities);
            return ListForComboBox1;
        }
        public List<Entity> getEntitiesCopy2()
        {
            List<Entity> ListForComboBox2 = new List<Entity>(Entities);
            return ListForComboBox2;
        }



        public void Delete(Entity entity)
        {
            Entities.Remove(entity);
        }


        
        public void Update(int id, IKingdom kingdom, string name, IDiet diet, IHabitat habitat, int atkPoints, int defPoints, bool rangeAttack, int maxLife, int maxEnergy, int defenseShield)
        {
            foreach (Entity EntityToUpdate in Entities)
            {
                if (EntityToUpdate.Id == id)
                {
                    EntityToUpdate.Kingdom = kingdom;
                    EntityToUpdate.Name = name;
                    EntityToUpdate.Diet = diet;
                    EntityToUpdate.HabitatList = habitat;
                    EntityToUpdate.AttackPoints = atkPoints;
                    EntityToUpdate.DefensePoints = defPoints;
                    EntityToUpdate.AttackRange = rangeAttack;
                    EntityToUpdate.MaxLife = maxLife;
                    EntityToUpdate.MaxEnergy = maxEnergy;
                    EntityToUpdate.DefenseShield = defenseShield;
                    break;
                }
            }
        }

        public void Update(Entity entityToModify, Entity entityModified)
        {
            
            int index = Entities.FindIndex(e => e == entityToModify);

            if (index != -1)
            {
                Entities[index] = entityModified;
                
            }
        }
        public void Eat(Entity entity, Food food)
        {
            if (food.Diet.Contains(entity.Diet))
                {
                    entity.CurrentEnergy += food.EnergyValue;
                }
                else throw new Exception($"no es compatible con la dieta. {food.Name} {food.DietNames} != {entity.Name} {entity.Diet}");
        }
    
    }
}
