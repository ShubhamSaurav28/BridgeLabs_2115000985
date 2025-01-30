/* using System;

class BMICalculator{
    public static void CalculateBMI(double[,] personData){
        for(int i=0;i<personData.GetLength(0);i++){
            double weight = personData[i,0];
            double heightInCm = personData[i,1];
            double heightInMeters = heightInCm/100;
            personData[i,2] = weight/(heightInMeters*heightInMeters);
        }
    }
    public static string[] GetBMIStatus(double[,] personData){
        string[] statusArray = new string[personData.GetLength(0)];
        for(int i=0;i<personData.GetLength(0);i++){
            double bmi = personData[i,2];
            if(bmi<18.5){
				status[i] = "Underweight";
			}
            else if(bmi<25.0){
				status[i] = "Normal weight";
			}
            else if(bmi<40.0){
				status[i] = "Overweight";
			}
            else{
				status[i] = "Obesity";
			}
        }
        return statusArray;
    }
    public static void Main(string[] args){
        double[,] teamData = new double[10, 3];
        for(int i=0;i<10;i++){
            Console.WriteLine($"Enter details for Person {i + 1}:");
            Console.Write("Enter weight (kg): ");
            teamData[i,0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height (cm): ");
            teamData[i,1] = Convert.ToDouble(Console.ReadLine());
        }
        CalculateBMI(teamData);
        string[] bmiStatuses = GetBMIStatus(teamData);
        Console.WriteLine("BMI Results:");
        for(int i=0;i<10;i++){
            Console.WriteLine($"Person {i+1} - Weight: {teamData[i,0]} kg, Height: {teamData[i,1]} cm, BMI: {teamData[i,2]:F2}, Status: {bmiStatuses[i]}");
        }
    }
}
 */