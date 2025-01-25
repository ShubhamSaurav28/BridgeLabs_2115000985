/* using System;

class GradeCalculation{
    public static void Main(){
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());
        int[] physicsMarks = new int[numberOfStudents];
        int[] chemistryMarks = new int[numberOfStudents];
        int[] mathsMarks = new int[numberOfStudents];
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];
        for(int i=0;i<numberOfStudents;i++){
            Console.WriteLine($"Enter marks for student {i + 1}:");
            Console.Write("Physics: ");
            physicsMarks[i] = int.Parse(Console.ReadLine());
            Console.Write("Chemistry: ");
            chemistryMarks[i] = int.Parse(Console.ReadLine());
            Console.Write("Maths: ");
            mathsMarks[i] = int.Parse(Console.ReadLine());
            double totalMarks = physicsMarks[i]+chemistryMarks[i]+mathsMarks[i];
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
            Console.WriteLine($"Student {i + 1}: Marks: Physics: {physicsMarks[i]}, Chemistry: {chemistryMarks[i]}, Maths: {mathsMarks[i]}");
            Console.WriteLine($"Percentage: {percentages[i]}%, Grade: {grades[i]}");
        }
    }
}
  */