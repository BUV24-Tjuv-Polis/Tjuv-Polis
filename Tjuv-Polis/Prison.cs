namespace Tjuv_Polis;

public class Prison : Thief
{

    public Prison(string name) : base(name)
    {
        Sentance = false;

    }

    public static int SentanceTime { get; set; }
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

    public static void DisplayInmates()
    {
        int i = 0;
        foreach (var inmate in Inmates)
        {
            Console.SetCursorPosition(1, 16 + i);
            Console.Write($"{inmate.Name} is in prison");
            i++;
        }
    }

    public void isSentanced(List<Thief> Inmates)
    {
        Sentance = true;
    }

}