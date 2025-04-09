using Tjuv_Polis.Models;

namespace Tjuv_Polis;

internal class Program
{
    static void Main(string[] args)
    {


        Person persons = new Person();
        List<Person> list = persons.ListPerson();
        Random random = new Random();


        foreach (Person person in list)
        {
            person.setx += random.Next(1, 120 - 1);
            person.sety += random.Next(1, 15 - 1);
        }

        IUI UI = new UI();
        UI.VisualCreateBorder();
        while (true)
        {
            UI.CheckCollision(list);


            Console.SetCursorPosition(22, 16);
            News.TheNews();


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
                Prison.DisplayInmates();
                Console.CursorVisible = false;
            }

            Thread.Sleep(20);
        }


    }
}