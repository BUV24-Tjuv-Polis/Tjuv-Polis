namespace Tjuv_Polis;



public class Person : Item
{
    public int P { get; set; }
    public int L { get; set; }

    private static Random random = new Random();

    public Item Pocket { get; set; }

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
        Pocket = new Item();
        y_direction = random.Next(-1, 2);
        x_Direction = random.Next(-1, 2);
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
       new Thief("Hans"),
        new Police("Lukas"),
       new Police("Laif"),
       new Police("Hugo"),
       new Police("Maja"),
       new Thief("Hans"),
       new Thief("Gunilla"),
       new Thief("Ola"),new Thief("Hans"),
       new Thief("Gunilla"),
       new Thief("Ola"),new Thief("Hans"),
       new Thief("Gunilla"),
       new Thief("Ola"),new Thief("Hans"),
       new Thief("Gunilla"),
       new Thief("Ola"),new Thief("Hans"),
       new Thief("Gunilla"),
       new Thief("Ola"),new Thief("Hans")
       //new Thief("Gunilla"),
       //new Thief("Ola"),new Thief("Hans"),
       //new Thief("Gunilla"),
       //new Thief("Ola"),new Thief("Hans")
      

        };
        return list;
    }

    public void DeletePerson(string name)
    {
        List<Person> persons = ListPerson();
        for (int i = 0; i < persons.Count; i++)
        {
            if (persons[i].Name == name)
            {
                persons.RemoveAt(i);
                break;
            }
        }
    }

}

public class Thief : Person
{
    public List<Item> StolenProperties {  get; set; } = new List<Item>();
    public Thief(string name) : base(name)
    {


    }
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
    public Police(string name) : base(name)
    {


    }
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
    public Citizen(string name) : base(name)
    {
        InventoryItem.FillInventory();
    }
    public override void displaychar()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.Write("C");

        Console.ForegroundColor = ConsoleColor.White;

    }




}