namespace Tjuv_Polis;

internal class Program
{
    static void Main(string[] args)
    {
        Interface theBorder = new Interface();
        theBorder.DrawBorder(120, 15, 0, 0);

        Interface thePrisonBorder = new Interface();

        theBorder.DrawBorder(20, 15, 0, 15);

        Interface theNewsBorder = new Interface();

        theBorder.DrawBorder(99, 15, 21, 15);


        Console.SetCursorPosition(22, 16);
        News.AddNews("åååå nej", "Tjuv tog någonting");
        News.TheNews();




        Console.ReadKey();

        List<Person> list = new List<Person>
       {
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
       new Thief("Gunilla"),
       new Thief("Ola"),
       new Thief("Roger")

        };

        Interface itn = new Interface();
        Random random = new Random();

        foreach (Person person in list)
        {

            person.setx += random.Next(1, 120 - 1);
            person.sety += random.Next(1, 15 - 1);



        }

        while (true)
        {
            Console.Clear();
            foreach (Person person in list)
            {
                if (person.setx <= 0 || person.setx >= Console.WindowWidth - 1 || person.sety <= 0 || person.sety >= Console.WindowHeight - 1)
                {
                    person.setx = person.StoreX;
                    person.sety = person.StoreY;
                }

                person.setx += random.Next(-1, 2);
                person.sety += random.Next(-1, 2);

                Console.SetCursorPosition(person.setx, person.sety);
                person.displaychar();
            }

            Thread.Sleep(100);
        }

    }
}