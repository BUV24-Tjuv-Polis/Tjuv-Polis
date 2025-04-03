
namespace Tjuv_Polis;

internal class Program
{
    static void Main(string[] args)
    {






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

        Random random = new Random();

        foreach (Person person in list)
        {

            person.setx += random.Next(1, 120 - 1);
            person.sety += random.Next(1, 15 - 1);



        }

        Interface theBorder = new Interface();
        theBorder.DrawBorder(120, 15, 0, 0);

        Interface thePrisonBorder = new Interface();

        theBorder.DrawBorder(20, 15, 0, 15);

        Interface theNewsBorder = new Interface();

        theBorder.DrawBorder(99, 15, 21, 15);


        Console.SetCursorPosition(22, 16);
        News.AddNews("åååå nej", "Tjuv tog någonting");
        News.TheNews();
        while (true)
        {



            Console.CursorVisible = false;

            foreach (Person person in list)
            {

                if (person.setx <= 1 || person.setx >= 118 || person.sety <= 1 || person.sety >= 13)
                {
                    person.setx = person.StoreX;
                    person.sety = person.StoreY;
                }

                person.setx += random.Next(-1, 2);
                person.sety += random.Next(-1, 2);

                if (person.P != person.setx || person.L != person.sety)
                {
                    Console.SetCursorPosition(person.P, person.L);
                    Console.Write(" ");
                }
                person.P = person.setx;
                person.L = person.sety;




                Console.SetCursorPosition(person.setx, person.sety);
                person.displaychar();
            }
            Thread.Sleep(100);
        }

    }
}