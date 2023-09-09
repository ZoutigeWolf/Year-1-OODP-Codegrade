public class Container
{
    public string Code { get; }
    public string Manifest { get; }
    public string[] Categories { get; }
    public string Origin { get; }
    public double Weight { get; }
    public int Status { get; set; }

    public Container(string code, string manifest, string[] categories, string origin, string weight, int status = 0)
    {
        this.Code = code;
        this.Manifest = manifest;
        this.Categories = categories;
        this.Origin = origin;
        this.Weight = Math.Round(double.Parse(weight[..^4]) * 0.45359237, 2);
        this.Status = status;
    }

    public override string ToString() =>
        $"Container(" +
        $"Code:'{Code}', " +
        $"Manifest:'{Manifest}', " +
        $"Categories:'{string.Join(',', Categories)}', " +
        $"Origin:'{Origin}', " +
        $"Status:'{Status}', " +
        $"Weight:'{Weight}')";
}