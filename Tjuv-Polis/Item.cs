using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tjuv_Polis;

public class Item
{
    // Medboragens inventory
    public Stack<Item> Inventory { get; set; }

    // Tjuvens inventory
    public List<Item> Stole_Properties  { get; set; }

    // Polisens invnetory
    public List<Item> Seized_Properties { get; set; }

    public void FillInventory()
    {
        Stack<Item> items = new Stack<Item>
        {
        
        };
    }

}
