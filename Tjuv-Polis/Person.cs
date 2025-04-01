using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tjuv_Polis;

public class Person
{
    private static Random random = new Random();
    public int x { get; set; }
    public int y { get; set; }
    public int x_Direction { get; set; }
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