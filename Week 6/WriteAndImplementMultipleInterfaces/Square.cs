using System.Text;

public class Square : IDrawable, IResizable
{
    public int Size { get; private set; }
    public Square(int size) => Size = size;

    public void Draw()
    {
        for (int y = 0; y < Size; y++)
        {
            StringBuilder s = new StringBuilder();

            for (int x = 0; x < Size; x++)
            {
                s.Append('*');
            }
            
            Console.WriteLine(s.ToString());
        }
    }

    public void Resize(double scale) => Size = (int)(Size * scale);
}