namespace WhileTheGettingIsBad;

class Program
{
    public static void Main(string[] args)
    {
        List<string> fileList = new List<string>()
        {
            "OODP assignment.docx",
            "Project Presentation.pptx",
            "TODO list.xlsx",
        };

        string whichFileToDelete = fileList[0];

        Console.WriteLine("File selected to delete: " + whichFileToDelete);
        
        DateTime start = DateTime.Now;

        while (true)
        {
            Console.WriteLine("Really delete this file? (y/n)");
            string confirm = (Console.ReadLine() ?? "");

            if (confirm == "y")
            {
                fileList.Remove(whichFileToDelete);
                Console.WriteLine("File deleted");
                break;
            }

            if ((DateTime.Now - start).TotalSeconds > 5) break;
        }
    }
}