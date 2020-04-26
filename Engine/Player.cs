using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player : LivingCreature
    {

        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }



        public Player(int gold, int experiencePoints, int level, int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            /*we will have our lists in the constructor so that they are not null but empty
             * you can add objects into an empty list but not a null list*/
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }


        }
   
}
