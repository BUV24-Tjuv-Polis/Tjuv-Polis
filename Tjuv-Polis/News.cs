﻿namespace Tjuv_Polis;
public class News
{
    public string Content { get; set; }

    public News(string content)
    {
        Content = content;
    }

    public static List<News> newsList = new List<News>();
    public static void AddNews(string content)
    {
        newsList.Add(new News(content));
    }

    public static void ClearNews()
    {
        for (int i = 16; i < 16 + 13; i++)
        {
            Console.SetCursorPosition(22, i);
            Console.Write("".PadRight(80));
        }
    }

    public static void TheNews()
    {
        ClearNews();

        if (newsList.Count > 13)
        {
            newsList.RemoveAt(0);
        }
        if (newsList.Count <= 13)
        {
            for (int i = 0; i < newsList.Count; i++)
            {
                Console.SetCursorPosition(22, 16 + i);
                Console.Write($"{newsList[i].Content}\n");
            }
        }
        else
        {
            for (int i = 0; i < 13; i++)
            {
                Console.SetCursorPosition(22, 16 + i);
                Console.Write($"{newsList[newsList.Count - 13 + i].Content}");
            }
        }
    }
}