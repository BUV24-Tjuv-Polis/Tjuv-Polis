namespace Tjuv_Polis;

public class Person : Item
{
    public int lastX { get; set; }
    public int lastY { get; set; }

    private static Random random = new Random();

    public string? Name { get; set; }

    // Positionen X-Axel
    private int x;

    public int StoreX { get; set; }
    public int StoreY { get; set; }
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

    public Person(string name = null)
    {
        Name = name;
        x = random.Next(2, 118);
        y = random.Next(2, 13);
        StoreX = x;
        StoreY = y;
    }

    public virtual void displaychar()
    {
        Console.WriteLine("Ö");
    }

    // Skapa en klass för random av namn och och olika typer av personer.
    public List<Person> ListPerson()
    {

        List<Person> list = new List<Person>
        {
       new Citizen("Erik"),
       new Citizen("Johan"),
       new Citizen("Ella"),
       new Citizen("Simon"),
       new Citizen("Erik"),
       new Citizen("Johan"),
       new Citizen("Ella"),
       new Citizen("Simon"),
       new Police("Jossan"),
       new Police("Lukas"),
       new Police("Laif"),
       new Police("Hugo"),
       new Police("Maja"),
        new Police("Lukas"),
       new Police("Laif"),
       new Police("Hugo"),
       new Police("Maja"),
       new Thief("Hans"),
       new Thief("Hans"),
       new Thief("Gunilla"),
       new Thief("Ola"),
       new Thief("Hans"),
        };
        return list;
    }
}

public class Thief : Person
{
    public List<Item> StolenProperties { get; set; } = new List<Item>();
    public Thief(string name) : base(name) { }

    public override void displaychar()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("T");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public void AddStolenItem(Item item)
    {
        StolenProperties.Add(item);
    }
}


public class Police : Person
{
    public Police(string name) : base(name) { }

    public override void displaychar()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("P");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

public class Citizen : Person
{

    public Item InventoryItem { get; set; } = new Item();
    public Citizen(string name) : base(name) { InventoryItem.FillInventory(); }

    public override void displaychar()
    {
        if (InventoryItem.Inventory.Count <= 0)
        {
            Console.Write("C");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("C");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}