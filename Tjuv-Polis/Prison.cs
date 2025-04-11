using System;
using System.Security.Cryptography.X509Certificates;

namespace Tjuv_Polis;

public class Prison : Thief
{

    public static Dictionary<Thief, DateTime> InmateTime = new Dictionary<Thief, DateTime>();

    public Prison(string name) : base(name)
    {
        Sentance = false;
        
    }

    public static int SentanceTime { get; set; }
    // Antal tjuvar i finkan
    public static List<Thief> Inmates { get; set; } = new List<Thief>();
    public static int Capazite { get; set; } = 10;
    public static bool Sentance { get; set; }

    //public void isSentanced(List<Thief> Inmates)
    //{
    //    Sentance = true;
    //}

    public static Random random = new Random();


    //Skapa en metod som hanterar både fängelset och vanliga gridet.
    // bool för att se om de är inmates eller ej. 
    // inparametrar för att göra den icke repetetativ.
    // lägg metod i UI istället. 
    public static void DisplayInmates()
    {
        int i = 0;

        List<Person> list = new List<Person>();

        foreach (var inmate in Inmates.AsEnumerable().Reverse())
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

            SentanceTime--;

            if (SentanceTime <= 0)
            {
                Sentance = false;
                list.Add(inmate);
            } 

            //Thread.Sleep(1000);
        }

        foreach (var inmate in list)
        {
            list.Remove(inmate);
        }
    }

     

        public static int SentanceDuration(List<Item> StolenProperties)
    {
        return StolenProperties.Count * 10;
    }


    
    public static void AddToPrison(Thief thief)
    {
        
        
        Inmates.Add(thief);
        InmateTime[thief] = DateTime.Now;

        Sentance = true;
        if (Sentance)
        {
            thief.set_y_Direction = random.Next(-1, 2);
            thief.set_x_Directions = random.Next(-1, 2);
            thief.setx = random.Next(2, 17);
            thief.sety = random.Next(17, 28);
            thief.StoreX = thief.setx;
            thief.StoreY = thief.sety;
            SentanceTime = 10;
        }
        
    }
    //METOD FÖR HUR LÄNGE DEM SITTER? 
}