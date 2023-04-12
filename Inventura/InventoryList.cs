using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryLib;

namespace Inventura
{
    public class InventoryList
    {
        Scanner scanner = new Scanner();
        public List<InventoryItem> Inventory { get; set; } = new List<InventoryItem>();

        public InventoryList()
        {
            LoadItems();
        }


        public void LoadItems()
        {
            List<string> itemsInString = new List<string>();
            itemsInString = scanner.GetEntries();

            foreach (string s in itemsInString)
            {
                string[] split = s.Split(';');
                int id = int.Parse(split[0]);
                string name = split[1];

                InventoryItem newItem = new InventoryItem(id, name);
                AddItem(newItem);

            }


        }

        public void AddItem(InventoryItem item)
        {
            bool consist = false;

            foreach(InventoryItem i in Inventory)
            {
                if(i.ID == item.ID)
                {
                    i.Count++;
                    consist = true;
                }
            }
            if ( consist==false ) Inventory.Add(item);
            
        }
    }
}
