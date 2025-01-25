/* using System;

class BonusCalculation{
    public static void Main(){
        double[] salary = new double[10];
        double[] yearsOfService = new double[10];
        double[] newSalary = new double[10];
        double[] bonus = new double[10];
        double totalBonus = 0, totalOldSalary = 0;
		double totalNewSalary = 0;
        for(int i=0;i<10;i++){
            Console.Write("Enter salary for employee {0}: ", i + 1);
            while(!double.TryParse(Console.ReadLine(), out salary[i]) || salary[i]<=0){
                Console.Write("Invalid input! Enter a valid salary for employee {0}: ", i + 1);
            }
            Console.Write("Enter years of service for employee {0}: ", i + 1);
            while(!double.TryParse(Console.ReadLine(), out yearsOfService[i]) || yearsOfService[i]<0){
                Console.Write("Invalid input! Enter valid years of service for employee {0}: ", i + 1);
            }
            if(yearsOfService[i]>=5){
                bonus[i] = salary[i]*0.05;
			}
            else{
                bonus[i] = salary[i]*0.02;
			}
            newSalary[i] = salary[i]+bonus[i];
            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }
        Console.WriteLine("\nTotal Bonus Paid: " + totalBonus);
        Console.WriteLine("Total Old Salary Paid: " + totalOldSalary);
        Console.WriteLine("Total New Salary Paid: " + totalNewSalary);
    }
}
 */