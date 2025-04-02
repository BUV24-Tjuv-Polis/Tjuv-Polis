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
        set { x_Direction = value; }
    }
    // Riktning Y-Axel

    private int y_direction;

    public int set_y_Direction
    {
        get { return y_direction; }
        set { y_direction = value; }
    }

    public Person(string name = null)
    {
        Name = name;
        y_direction = random.Next(-1, 2);
        x_Direction = random.Next(-1, 2);
        x = random.Next(1, Console.WindowWidth-1);
        y = random.Next(1, Console.WindowHeight - 2);
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
    public override void displaychar()
    {

        Console.Write("T");
    }
}

public class Police : Person
{
    public Police(string name) : base(name)
    {
       

    }
    public override void displaychar()
    {

        Console.Write("P");
    }
}

public class Citizen : Person
{
    public Citizen(string name) : base(name)
    {
       

    }
    public override void displaychar()
    {

        Console.Write("C");
    }
}