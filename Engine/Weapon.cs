using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Weapon : Item
    {

        public int MinimumDamage { get; set; }
        public int MaxmimumDamage { get; set; }


         
        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage  ) :base(id, name, namePlural)
        {
            MinimumDamage = minimumDamage;
            MaxmimumDamage = maximumDamage;
        }
    }
}
 