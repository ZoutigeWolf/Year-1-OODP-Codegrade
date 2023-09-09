public class GrayscaleImage
{
    public int Height { get; }
    public int Width { get; }
    public int[,] PixelData { get; }

    public GrayscaleImage(int height, int width)
    {
        this.Height = height;
        this.Width = width;
        this.PixelData = new int[height, width];
    }

    public GrayscaleImage(int[,] pixelData)
    {
        this.Height = pixelData.GetLength(0);
        this.Width = pixelData.GetLength(1);
        this.PixelData = pixelData;
    }
}