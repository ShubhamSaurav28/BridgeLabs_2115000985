/* using System;

class GradeCalculation2D{
    public static void Main(){
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());
        int[,] marks = new int[numberOfStudents,3];
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];
        for(int i=0;i<numberOfStudents;i++){
            Console.Write("Enter marks for Physics, Chemistry, and Maths for student {0}: ", i + 1);
            for(int j=0;j<3;j++){
                marks[i,j] = int.Parse(Console.ReadLine());
                if (marks[i,j] < 0) marks[i,j] = 0;
            }
            double totalMarks = marks[i,0] + marks[i,1] + marks[i,2];
            percentages[i] = totalMarks/3.0;
            if(percentages[i]>=80){
				grades[i] = "A";
			}
            else if(percentages[i]>=70){
				grades[i] = "B";
			}
            else if(percentages[i]>=60){
				grades[i] = "C";
			}
            else if(percentages[i]>=50){
				grades[i] = "D";
			}
			else if(percentages[i]>=40){
				grades[i] = "E";
			}
            else{
				grades[i] = "R";
			}
        }
        for(int i=0;i<numberOfStudents;i++){
            Console.WriteLine($"Student {i + 1}: Marks: {marks[i, 0]}, {marks[i, 1]}, {marks[i, 2]}, Percentage: {percentages[i]}, Grade: {grades[i]}");
        }
    }
}
  */