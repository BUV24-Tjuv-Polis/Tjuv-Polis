namespace Tjuv_Polis;

public class Prison : Thief
{
    public Prison(string name) : base(name)
    {
        Sentance = false;
        Inmates.Add(new Thief(name));
    }
    // Antal tjuvar i finkan
    public List<Thief> Inmates { get; set; } = new List<Thief>();

    // Hur stor finkan är
    public int Capazite { get; set; }

    // Om tjuven är tagen eller inte
    public bool Sentance { get; set; }

    public void isSentanced (List<Thief> Inmates)
    {
        Sentance = true;
    }

}