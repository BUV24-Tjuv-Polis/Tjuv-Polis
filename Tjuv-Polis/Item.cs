using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tjuv_Polis;

public class Item
{
    // Namn för 
    public string? ItemName { get; set; } = null;

    public override string ToString()
    {
        return ItemName;
    }

    // Medboragens inventory
    public Stack<Item> Inventory { get; set; } = new Stack<Item>();

    // Tjuvens inventory
    public List<Item> Stole_Properties { get; set; } = new List<Item>();

    // Polisens invnetory
    public List<Item> Seized_Properties { get; set; } = new List<Item>();

    public Item(string itemName = null)
    {
        ItemName = itemName;
    }

    public void FillInventory()
    {
        Inventory.Push(new Item("Wallet"));
        Inventory.Push(new Item("Watch"));
        Inventory.Push(new Item("Phone"));
        Inventory.Push(new Item("Keys"));
    }

    //Tjuven tar av medborgaren
    public Item? ThiefPopItem(Citizen citizen, Thief thief)
    {
        if(citizen.InventoryItem.Inventory.Count > 0)
        {
            Item stolen = citizen.InventoryItem.Inventory.Pop();
            thief.AddStolenItem(stolen);
            return stolen;
        }
        return null;
    }
    //Polisen tar allt av tjuven
    public bool CopSiezedAll(Thief thief)
    {
        if (thief.StolenProperties.Count > 0)
        {
            Seized_Properties.AddRange(thief.StolenProperties);
            thief.StolenProperties.Clear();
            return true;
        }

        return false;
    }

    // Senare implementation för backlog
    public void ShowInventory()
    {
        if (Inventory.Count == 0)
        {
            Console.WriteLine("It's empty!");
        }

        else
        {
            Console.WriteLine("Inventory:");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"{item.ItemName}");
            }
        }

            
    }

}
