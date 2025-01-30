using System;

class EmployeeBonusCalculator{
    public static void Main(){    int[,] employeeData = GenerateEmployeeData(10);
        double[,] salaryAndBonusData = CalculateSalariesAndBonuses(employeeData);
        DisplayResults(employeeData, salaryAndBonusData);
    }
    public static int[,] GenerateEmployeeData(int numberOfEmployees){    
		Random random = new Random();
        int[,] employeeDetails = new int[numberOfEmployees, 2];
        for (int i = 0; i < numberOfEmployees; i++){
            employeeDetails[i, 0] = random.Next(30000, 100000); // Generate random salary
            employeeDetails[i, 1] = random.Next(1, 11);         // Generate random years of service
        }

        return employeeDetails;
    }
    public static double[,] CalculateSalariesAndBonuses(int[,] employeeDetails){
        int totalEmployees = employeeDetails.GetLength(0);
        double[,] salaryBonusDetails = new double[totalEmployees, 2];
        for (int i = 0; i < totalEmployees; i++){
            int currentSalary = employeeDetails[i, 0];
            int yearsOfService = employeeDetails[i, 1];

            double bonusPercentage = (yearsOfService > 5) ? 0.05 : 0.02;
            double bonusAmount = currentSalary * bonusPercentage;
            double updatedSalary = currentSalary + bonusAmount;

            salaryBonusDetails[i, 0] = updatedSalary;
            salaryBonusDetails[i, 1] = bonusAmount;
        }

        return salaryBonusDetails;
    }
    public static void DisplayResults(int[,] employeeDetails, double[,] salaryBonusDetails){
        double totalOldSalaries = 0;
        double totalNewSalaries = 0;
        double totalBonuses = 0;
        Console.WriteLine("Emp#\tOld Salary\tYears of Service\tBonus Amount\tNew Salary");
        for(int i=0;i<employeeDetails.GetLength(0);i++){
            int oldSalary = employeeDetails[i, 0];
            int yearsOfService = employeeDetails[i, 1];
            double bonus = salaryBonusDetails[i, 1];
            double newSalary = salaryBonusDetails[i, 0];
            totalOldSalaries += oldSalary;
            totalNewSalaries += newSalary;
            totalBonuses += bonus;
            Console.WriteLine($"{i + 1}\t{oldSalary}\t\t{yearsOfService}\t\t\t{bonus:F2}\t\t{newSalary:F2}");
        }
        Console.WriteLine("\nSummary:");
        Console.WriteLine($"Total Old Salaries: {totalOldSalaries:F2}");
        Console.WriteLine($"Total New Salaries: {totalNewSalaries:F2}");
        Console.WriteLine($"Total Bonus Amount: {totalBonuses:F2}");
    }
}