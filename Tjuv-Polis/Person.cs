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
    public List<Person> ListPerson()
    {

        List<Person> list = new List<Person>
        {
           new Citizen("Johan"),
           new Citizen("Lars"),
           new Citizen("Elin"),
           new Citizen("Oskar"),
           new Citizen("Anna"),
           new Citizen("Viktor"),
           new Citizen("Maja"),
           new Citizen("Karl"),
           new Citizen("Agnes"),
           new Citizen("Filip"),
           new Citizen("Ingrid"),
           new Citizen("Emil"),
           new Citizen("Tilde"),

           new Thief("Gunilla"),
           new Thief("Johan"),
           new Thief("Freja"),
           new Thief("Nils"),
           new Thief("Lovisa"),
           new Thief("Simon"),
           new Thief("Ida"),
           new Thief("Malte"),

           new Police("Erik"),
           new Police("Sofia"),
           new Police("Anders"),
           new Police("Karin"),
           new Police("Henrik"),
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