/* using System;

class LeapYearChecker{
    public static bool IsLeapYear(int year){
        return (year%4==0) && (year%100!=0 || year%400==0);
    }
    public static void Main(string[] args){
        Console.Write("Enter a year (>= 1582): ");
        int inputYear = Convert.ToInt32(Console.ReadLine());
        if(inputYear<1582){
            Console.WriteLine("The program only supports years >= 1582.");
            return;
        }
        bool leapYearStatus = IsLeapYear(inputYear);
        Console.WriteLine(leapYearStatus?$"{inputYear} is a Leap Year.":$"{inputYear} is NOT a Leap Year.");
    }
}
 */