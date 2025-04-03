namespace Tjuv_Polis;

public class Interface
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
}
