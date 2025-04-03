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
        foreach (var news in newsList)
        {
            Console.WriteLine($"Title: {news.Title}  Content: {news.Content}\n");
        }
    }

}


