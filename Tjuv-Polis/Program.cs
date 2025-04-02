namespace Tjuv_Polis;

internal class Program
{
    static void Main(string[] args)
    {
        List<Person> list = new List<Person>
       {
           new Citizen("erik"),
           new Citizen("erik"),
           new Citizen("erik"),
           new Citizen("erik"),
           new Police("jossan"),
           new Police("jossan"),
           new Police("jossan"),
           new Police("jossan"),
           new Police("jossan"),
           new Thief("hans"),
           new Thief("hans"),
           new Thief("hans"),
           new Thief("hans")

       };

        Interface itn = new Interface();
        while (true)
        {
            foreach (Person person in list)
            {
                Console.SetCursorPosition(person.setx--, person.sety);
                person.displaychar();
            }

        }
    }
}
