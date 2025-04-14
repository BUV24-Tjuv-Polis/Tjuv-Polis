namespace Tjuv_Polis;

public class Prison : Thief
{
    public static Dictionary<Thief, int> SentenceDurations = new Dictionary<Thief, int>();

    public Prison(string name) : base(name)
    {
        Sentance = false;
    }
    public static int SentanceTime { get; set; }
    // Antal tjuvar i finkan
    public static List<Thief> Inmates { get; set; } = new List<Thief>();
    public static bool Sentance { get; set; }

    public static Random random = new Random();

    public static void DisplayInmates()
    {
        List<Thief> toRealease = new List<Thief>();
        List<Thief> thief = new List<Thief>();

        foreach (var inmate in Inmates.AsEnumerable().Reverse())
        {
            if (inmate.setx <= 2 || inmate.setx >= 17 || inmate.sety <= 16 || inmate.sety >= 26)
            {
                inmate.setx = inmate.StoreX;
                inmate.sety = inmate.StoreY;
            }
            inmate.setx += random.Next(-1, 2);
            inmate.sety += random.Next(-1, 2);

            if (inmate.lastX != inmate.setx || inmate.lastY != inmate.sety)
            {
                Console.SetCursorPosition(inmate.lastX, inmate.lastY);
                Console.Write(" ");
            }
            inmate.lastX = inmate.setx;
            inmate.lastY = inmate.sety;

            Console.SetCursorPosition(inmate.setx, inmate.sety);

            Console.Write("\x1b[33mT\x1b[0m");

            if (SentenceDurations.ContainsKey(inmate))
            {
                SentenceDurations[inmate]--;
                if (SentenceDurations[inmate] <= 0)
                {
                    toRealease.Add(inmate);
                    thief.Add(inmate);
                    Sentance = false;
                }
            }
        }
        foreach (var inmate in toRealease)
        {
            SentenceDurations.Remove(inmate);
            Inmates.Remove(inmate);
            Console.SetCursorPosition(inmate.lastX, inmate.lastY);
            Console.Write(" ");
            BackToCity(inmate);
            Program.list.Add(inmate);
        }
    }

    public static void BackToCity(Thief thief)
    {
        if (!Sentance)
        {
            thief.setx = random.Next(2, 118);
            thief.sety = random.Next(2, 13);
            thief.StoreX = thief.setx;
            thief.StoreY = thief.sety;
        }
    }

    public static void AddToPrison(Thief thief)
    {
        Inmates.Add(thief);
        Sentance = true;
        if (Sentance)
        {
            thief.setx = random.Next(2, 17);
            thief.sety = random.Next(17, 28);
            thief.StoreX = thief.setx;
            thief.StoreY = thief.sety;

            if (thief.StolenProperties.Count == 3)
            {
                SentanceTime = 500;
                thief.StolenProperties.Clear();
            }
            else if (thief.Inventory.Count == 2)
            {
                SentanceTime = 300;
                thief.StolenProperties.Clear();
            }
            else
            {
                SentanceTime = 100;
                thief.StolenProperties.Clear();
            }
            SentenceDurations[thief] = SentanceTime;
        }
    }
}