using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class InventoryItem
    {

        public Item Details { get; set; }
        public int Quantity { get; set; }

        public InventoryItem(int quantiy, Item details)
        {
            Details = details;
            Quantity = quantiy;
        }
    }
}
