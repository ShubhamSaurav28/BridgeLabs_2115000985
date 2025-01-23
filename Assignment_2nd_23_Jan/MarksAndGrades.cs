/* using System;

class MarksAndGrades{
    public static void Main(){
        Console.Write("Enter marks in Physics: ");
        int physics = int.Parse(Console.ReadLine());
        Console.Write("Enter marks in Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());
        Console.Write("Enter marks in Maths: ");
        int maths = int.Parse(Console.ReadLine());
        double percentage = (physics + chemistry + maths) / 3.0;
        Console.WriteLine($"Average Marks: {percentage:F2}");
        if(percentage>=80){
			Console.WriteLine("Grade: A (Level 4)");
		}
        else if(percentage>=70){
			Console.WriteLine("Grade: B (Level 3)");
		}
        else if(percentage>=60){
			Console.WriteLine("Grade: C (Level 2)");
		}
		else if(percentage>=50){
			Console.WriteLine("Grade: D (Level 1)");
		}
		else if(percentage>=40){
			Console.WriteLine("Grade: E (Level 1)");
		}
        else{
			Console.WriteLine("Grade: R (Remedial Standard)");
		}
    }
}
 */