/* using System;

class BMICalculator{
    public static void Main(){
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());
        double[] weight = new double[numberOfPersons];
        double[] height = new double[numberOfPersons];
        double[] bmi = new double[numberOfPersons];
        string[] status = new string[numberOfPersons];
        for(int i=0;i<numberOfPersons;i++){
            Console.Write("Enter weight for person {0}: ", i + 1);
            weight[i] = double.Parse(Console.ReadLine());
            Console.Write("Enter height for person (m) {0}: ", i + 1);
            height[i] = double.Parse(Console.ReadLine());
            bmi[i] = weight[i]/(height[i]*height[i]);
            if(bmi[i]<18.5){
				status[i] = "Underweight";
			}
            else if(bmi[i]<25.0){
				status[i] = "Normal weight";
			}
            else if(bmi[i]<40.0){
				status[i] = "Overweight";
			}
            else{
				status[i] = "Obesity";
			}
        }
        for(int i=0;i<numberOfPersons;i++){
            Console.WriteLine($"Person {i + 1}: Weight: {weight[i]}, Height: {height[i]}, BMI: {bmi[i]}, Status: {status[i]}");
        }
    }
}
  */