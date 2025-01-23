/* using System;

class BMICalculator{
    public static void Main(){
        Console.Write("Enter your weight in kg: ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Enter your height in cm: ");
        double height = double.Parse(Console.ReadLine())/100;
        double bmi = weight/(height*height);
        Console.WriteLine($"Your BMI is: {bmi:F2}");
        if(bmi<=18.4){
			Console.WriteLine("Underweight");
		}
        else if(bmi<25.0){
			Console.WriteLine("Normal weight");
		}
        else if(bmi<40.0){
			Console.WriteLine("Overweight");
		}
        else{
			Console.WriteLine("Obese");
		}
    }
}
 */