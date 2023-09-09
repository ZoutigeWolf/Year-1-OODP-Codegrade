public class GrayscaleImage
{
    public int[,] PixelData { get; }

    public GrayscaleImage(int[,] pixelData)
    {
        this.PixelData = pixelData;
    }

    public void AdjustBrightness(double multiplier)
    {
        for (int x = 0; x < PixelData.GetLength(0); x++)
        {
            for (int y = 0; y < PixelData.GetLength(1); y++)
            {
                PixelData[x, y] = (int)(PixelData[x,y] * multiplier);
            }
        }
    }
}