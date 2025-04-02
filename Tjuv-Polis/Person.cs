﻿using System;
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
        set { x = Random.Shared.Next(1, Console.WindowWidth); }
    }

    // Positionen Y-Axel

    private int y;

    public int sety
    {
        get { return y; }
        set { y = Random.Shared.Next(1, Console.WindowHeight -1); }
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
   
        Console.WriteLine("ö");
    }

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