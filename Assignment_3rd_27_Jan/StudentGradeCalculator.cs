using System;

class StudentGradeCalculator{
    public static void Main(){
        Console.Write("Enter the number of students: ");
        int studentCount = int.Parse(Console.ReadLine());
        int[,] marks = GenerateScores(studentCount);
        double[,] results = CalculateResults(marks);
        DisplayResults(marks, results);
    }
    public static int[,] GenerateScores(int studentCount){
        Random random = new Random();
        int[,] scores = new int[studentCount, 3]; // Columns: Physics, Chemistry, Maths

        for (int i = 0; i < studentCount; i++)
        {
            scores[i, 0] = random.Next(40, 101); // Physics marks
            scores[i, 1] = random.Next(40, 101); // Chemistry marks
            scores[i, 2] = random.Next(40, 101); // Maths marks
        }

        return scores;
    }

    // Calculate total, percentage, and grade
    public static double[,] CalculateResults(int[,] marks){
        int studentCount = marks.GetLength(0);
        double[,] results = new double[studentCount, 3]; // Columns: Total, Percentage, Grade (as int)

        for (int i = 0; i < studentCount; i++)
        {
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            double percentage = (total / 300.0) * 100;
            char grade = AssignGrade(percentage);

            results[i, 0] = total;         // Total marks
            results[i, 1] = percentage;   // Percentage
            results[i, 2] = grade;        // Grade as char
        }

        return results;
    }

    // Assign grade based on percentage
    public static char AssignGrade(double percentage){
        if (percentage >= 80) return 'A';
        if (percentage >= 70) return 'B';
        if (percentage >= 60) return 'C';
        if (percentage >= 50) return 'D';
        if (percentage >= 40) return 'E';
        return 'R'; // Fail
    }

    // Display results for all students
    public static void DisplayResults(int[,] marks, double[,] results){
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tPercentage\tGrade");
        double highestPercentage = 0;
        int topStudent = -1;
        for (int i = 0; i < marks.GetLength(0); i++){
            int physics = marks[i, 0];
            int chemistry = marks[i, 1];
            int maths = marks[i, 2];
            double total = results[i, 0];
            double percentage = results[i, 1];
            char grade = (char)results[i, 2];

            if (percentage > highestPercentage)
            {
                highestPercentage = percentage;
                topStudent = i + 1; // Store 1-based index
            }

            Console.WriteLine($"{i + 1}\t{physics}\t{chemistry}\t\t{maths}\t{total}\t{percentage:F2}%\t\t{grade}");
        }

        Console.WriteLine("\nSummary:");
        Console.WriteLine($"Top Student: Student #{topStudent} with {highestPercentage:F2}%");
    }
}

12