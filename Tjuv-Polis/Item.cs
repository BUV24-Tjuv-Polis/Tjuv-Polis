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

    // Senare implementation för backlog
    public void ShowInventory()
    {
        foreach (var item in Inventory)
        {
            Console.WriteLine(item);
        }
    }

}
