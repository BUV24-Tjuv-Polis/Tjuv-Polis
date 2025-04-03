using Tjuv_Polis.Models;

namespace Tjuv_Polis;

public class UI : IUI
{


    public void DrawBorder(int width, int height, int xOffset = 0, int yOffset = 0)
    {

        for (int x = 0; x < width; x++)
        {
            Console.SetCursorPosition(x + xOffset, yOffset);
            Console.Write("═");
            Console.SetCursorPosition(x + xOffset, yOffset + height - 1);
            Console.Write("═");
        }


        for (int y = 0; y < height; y++)
        {
            Console.SetCursorPosition(xOffset, y + yOffset);
            Console.Write("║");
            Console.SetCursorPosition(xOffset + width - 1, y + yOffset);
            Console.Write("║");
        }


        Console.SetCursorPosition(xOffset, yOffset);
        Console.Write("╔");
        Console.SetCursorPosition(xOffset + width - 1, yOffset);
        Console.Write("╗");
        Console.SetCursorPosition(xOffset, yOffset + height - 1);
        Console.Write("╚");
        Console.SetCursorPosition(xOffset + width - 1, yOffset + height - 1);
        Console.Write("╝");
    }
    public void VisualCreateBorder()
    {
        UI theBorder = new UI();
        theBorder.DrawBorder(120, 15, 0, 0);
        Console.SetCursorPosition(55, 0);
        Console.WriteLine("-THE CITY-");

        UI thePrisonBorder = new UI();
        theBorder.DrawBorder(20, 15, 0, 15);
        Console.SetCursorPosition(6, 15);
        Console.WriteLine("-PRISON-");

        UI theNewsBorder = new UI();
        theBorder.DrawBorder(99, 15, 21, 15);
        Console.SetCursorPosition(65, 15);
        Console.WriteLine("-BREAKING NEWS-");


        Console.SetCursorPosition(22, 16);
        News.AddNews("åååå nej", "Tjuv tog någonting");
        News.TheNews();
    }
}
