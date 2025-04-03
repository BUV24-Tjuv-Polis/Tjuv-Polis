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
    public void ThiefPopItem()
    {
        if(Inventory.Count > 0)
        {
            Stole_Properties.Add(Inventory.Pop());
        }
    }
    //Polisen tar allt av tjuven
    public void CopSiezedAll()
    {
        if (Stole_Properties.Count > 0)
        {
            Seized_Properties.AddRange(Stole_Properties);
            Seized_Properties.Clear();
        }
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
