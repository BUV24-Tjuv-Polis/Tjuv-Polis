using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tjuv_Polis;



public class Person
{
    private static Random random = new Random();

    public string? Name { get; set; }
    // Positionen X-Axel
    private int x;

    public int setx
    {
        get { return x; }
        set { x = value; }
    }

    // Positionen Y-Axel

    private int y;

    public int sety
    {
        get { return y; }
        set { y = value; }
    }

    // Riktning X-Axel
    
    private int x_Direction;

    public int set_x_Directions
    {
        get { return x_Direction; }
        set { x_Direction = Random.Shared.Next(-1, 2); }
    }
    // Riktning Y-Axel

    private int y_direction;

    public int set_y_Direction
    {
        get { return y_direction; }
        set { y_direction = Random.Shared.Next(-1, 2); }
    }

    public Person(string name)
    {
        Name = name;
 
    }

    public virtual void displaychar()
    {   
   
        Console.Write("ö");
    }

}

public class Thief : Person
{
    public Thief(string name) : base(name)
    {
       

    }
}

public class Police : Person
{
    public Police(string name) : base(name)
    {
       

    }
}

public class Citizen : Person
{
    public Citizen(string name) : base(name)
    {
       

    }
}