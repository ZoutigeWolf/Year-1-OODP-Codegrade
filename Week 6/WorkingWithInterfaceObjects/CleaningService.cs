static class CleaningService
{
    public static void Clean(ICleanable cleanable) => cleanable.Clean();

    public static void Clean(List<ICleanable> cleanables) => cleanables.ForEach(c => c.Clean());
}