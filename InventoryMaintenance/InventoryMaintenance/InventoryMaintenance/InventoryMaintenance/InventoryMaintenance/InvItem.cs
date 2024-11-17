//jon pack
//worked with luke

using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItem
    {
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public InvItem()
        {
            ItemNo = 00000000;
            Description = "N/A";
            Price = 0.00m;
        }

        public InvItem(int ItemNum, string Desc, decimal Cost) //constructor
        {
            ItemNo = ItemNum;
            Description = Desc;
            Price = Cost;
        }

        public String GetDisplayText() //get display text
        {
            return $"{ItemNo}    {Description} ({Price:C})";
        }

    }
}
