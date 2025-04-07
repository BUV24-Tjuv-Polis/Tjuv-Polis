namespace Tjuv_Polis.Models;
public interface IUI
{
    //public void DrawBorder(int width, int height, int xOffset = 0, int yOffset = 0);
    public void VisualCreateBorder();
    public void CheckCollision(List<Person> list);

}
