﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Weapon : Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public int MinimumDamage { get; set; }
        public int MaxmimumDamage { get; set; }
    }
}
 