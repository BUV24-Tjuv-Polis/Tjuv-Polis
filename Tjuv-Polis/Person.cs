using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tjuv_Polis;

public class Person
{
    private static Random random = new Random();

    // Positionen X-Axel
    public int x { get; set; }

    // Positionen Y-Axel
    public int y { get; set; }

    // Riktning X-Axel
    public int x_Direction { get; set; }

    // Riktning Y-Axel
    public int y_Direction { get; set; }

}

public class Thief : Person
{

}

public class Police : Person
{

}

public class Citizen : Person
{

}