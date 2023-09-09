namespace RetakingGrades;

class Program {
    public static void Main(string[] args)
    {
        List<double> grades = new List<double>() {6.5, 9.5, 4, 5, 4.5, 10, 7.1};

        for (int i = 0; i < grades.Count; i++)
        {
            double grade = grades[i];

            Console.WriteLine($"Grade: {grade}");

            if (grade < 5.5)
            {
                bool retake = false;

                while (true)
                {
                    Console.WriteLine("Retake this course? y/n");
                    string input = (Console.ReadLine() ?? "").ToUpper();

                    retake = input == "Y";

                    if (input == "Y" || input == "N")
                        break;
                }

                if (retake)
                    grades[i] = grade + 1;
            }
        }

        Console.WriteLine("Final Grades:");

        grades.ForEach(g => Console.WriteLine(g));
    }
}