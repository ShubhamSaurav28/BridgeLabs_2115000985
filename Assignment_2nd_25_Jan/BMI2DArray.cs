/* using System;

class BMI2DArray{
    public static void Main() {
        Console.Write("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());
        double[][] personData = new double[numberOfPersons][];
        string[] weightStatus = new string[numberOfPersons];
        for(int i=0;i<numberOfPersons;i++){
            personData[i] = new double[3]; 
            Console.Write("Enter weight for person {0}: ", i + 1);
            personData[i][0] = double.Parse(Console.ReadLine());
            Console.Write("Enter height for person (m) {0}: ", i + 1);
            personData[i][1] = double.Parse(Console.ReadLine());
            personData[i][2] = personData[i][0]/(personData[i][1]*personData[i][1]);
            if(personData[i][2]<18.5) {
                weightStatus[i] = "Underweight";
            }
            else if(personData[i][2]<25.0) {
                weightStatus[i] = "Normal weight";
            }
            else if(personData[i][2]<40.0) {
                weightStatus[i] = "Overweight";
            }
            else{
                weightStatus[i] = "Obesity";
            }
        }
        for(int i=0;i<numberOfPersons;i++){
            Console.WriteLine($"Person {i + 1}: Weight: {personData[i][0]}, Height: {personData[i][1]}, BMI: {personData[i][2]}, Status: {weightStatus[i]}");
        }
    }
}
 */