﻿using Tjuv_Polis.Models;

namespace Tjuv_Polis;

internal class Program
{
    private static Person persons = new Person();
    public static List<Person> list = persons.ListPerson();
    static async Task Main(string[] args)
    {
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
                // skapa en metod av detta
                if (person.setx <= 1 || person.setx >= 118 || person.sety <= 1 || person.sety >= 13)
                {
                    person.setx = person.StoreX;
                    person.sety = person.StoreY;
                }
                person.setx += random.Next(-1, 2);
                person.sety += random.Next(-1, 2);

                if (person.lastX != person.setx || person.lastY != person.sety)
                {
                    Console.SetCursorPosition(person.lastX, person.lastY);
                    Console.Write(" ");
                }
                person.lastX = person.setx;
                person.lastY = person.sety;

                Console.SetCursorPosition(person.setx, person.sety);
                person.displaychar();
                Console.CursorVisible = false;
            }
            Prison.DisplayInmates();
            await Task.Delay(55);
        }
    }
}