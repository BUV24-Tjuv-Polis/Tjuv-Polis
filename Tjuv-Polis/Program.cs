﻿namespace Tjuv_Polis;

internal class Program
{
    static void Main(string[] args)
    {

        List<Person> list = new List<Person>
       {
           new Citizen("erik"),
         
        
         

       };


        Random random = new Random();

        foreach (Person person in list)
        {

            person.setx += random.Next(1, Console.WindowWidth - 1);
            person.sety += random.Next(1, Console.WindowHeight - 1);



        }

        while (true)
        {
            Console.Clear();
            foreach (Person person in list)
            {
                person.setx += random.Next(-1, 2);
                person.sety += random.Next(-1, 2);

                Console.SetCursorPosition(person.setx, person.sety);
                person.displaychar();
            }
                int x =0, y =0;
          

            Thread.Sleep(100);
        }
    }
}
