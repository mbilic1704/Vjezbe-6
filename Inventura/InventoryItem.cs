using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryLib;

namespace Inventura
{
    public class InventoryItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public InventoryItem(int id, string name)
        {
            ID = id;
            Name = name;
            Count = 1;
            
        }
    }
}
