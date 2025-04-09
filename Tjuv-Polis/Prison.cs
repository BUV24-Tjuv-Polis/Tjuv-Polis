using System;

namespace Tjuv_Polis;

public class Prison : Thief
{
    
    public Prison(string name) : base(name)
    {
        Sentance = false;
        
    }
    // Antal tjuvar i finkan
    public static List<Thief> Inmates { get; set; } = new List<Thief>();

    // Hur stor finkan är
    public static int Capazite { get; set; } = 10;

    // Om tjuven är tagen eller inte
    public static bool Sentance { get; set; }

    //public void isSentanced(List<Thief> Inmates)
    //{
    //    Sentance = true;
    //}

    public static Random random = new Random();


    public static void DisplayInmates()
    {
        int i = 0;
        foreach (var inmate in Inmates)
        {
            //Console.SetCursorPosition(1, 16 + i);
            //Console.Write($"{inmate.Name} is in prison");


            if (inmate.setx <= 2 || inmate.setx >= 17 || inmate.sety <= 16 || inmate.sety >= 26)
            {
                inmate.setx = inmate.StoreX;
                inmate.sety = inmate.StoreY;
            }

            inmate.setx += random.Next(-1, 2);
            inmate.sety += random.Next(-1, 2);

            if (inmate.P != inmate.setx || inmate.L != inmate.sety)
            {
                Console.SetCursorPosition(inmate.P, inmate.L);
                Console.Write(" ");
            }
            inmate.P = inmate.setx;
            inmate.L = inmate.sety;

            Console.SetCursorPosition(inmate.setx, inmate.sety);


            Console.Write("\x1b[33mT\x1b[0m");
            
            
            i++;

            //Thread.Sleep(1000);
        }

    


    }
    public static void AddToPrison(Thief thief)
    {
        
        
            Inmates.Add(thief);
            Sentance = true;
        if (Sentance)
        {
            thief.set_y_Direction = random.Next(-1, 2);
            thief.set_x_Directions = random.Next(-1, 2);
            thief.setx = random.Next(2, 17);
            thief.sety = random.Next(17, 28);
            thief.StoreX = thief.setx;
            thief.StoreY = thief.sety;
        }
        
    }
    //METOD FÖR HUR LÄNGE DEM SITTER? 
}