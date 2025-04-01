using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tjuv_Polis;

internal class Prison
{
    // Antal tjuvar i finkan
    public string? Inmates { get; set; }

    // Hur stor finkan är
    public int Capazite { get; set; }

    // Om tjuven är tagen eller inte
    public bool Sentance { get; set; }

}
