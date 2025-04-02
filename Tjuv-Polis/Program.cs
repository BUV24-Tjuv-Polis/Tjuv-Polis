namespace Tjuv_Polis;

internal class Program
{
    static void Main(string[] args)
    {

        List<Person> list = new List<Person>
       {
           new Citizen("erik"),
         
        
         

       };

        Interface itn = new Interface();
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
          

        }
    }
}
