namespace Tjuv_Polis;
public class News
{

    public string Title { get; set; }
    public string Content { get; set; }




    public News(string title, string content)
    {
        Title = title;
        Content = content;
    }


    public static List<News> newsList = new List<News>();
    public static void AddNews(string title, string content)
    {

        newsList.Add(new News(title, content));

    }



    public static void TheNews()
    {

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
                for (int i = 0; i <13; i++)
            {
                Console.SetCursorPosition(22, 16 + i);
                Console.Write($"{newsList[newsList.Count - 13 + i].Content}");
            }
            }
        }

    }