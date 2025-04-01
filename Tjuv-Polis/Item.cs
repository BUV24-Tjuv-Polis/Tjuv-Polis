using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tjuv_Polis;

internal class Item
{
    // Medboragens inventory
    public string? Inventory { get; set; }

    // Tjuvens inventory
    public string? Stole_Properties  { get; set; }

    // Polisens invnetory
    public string? Seized_Properties { get; set; }

}
