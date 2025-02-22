/* using System;
using System.Text.RegularExpressions;

class ValidateLicensePlate{
    public static bool IsValidLicensePlate(string plate){
        return Regex.IsMatch(plate,@"^[A-Z]{2}\d{4}$");
    }
    public static void Main(){
        string[] testPlates = {"AB1234","A12345","XY5678","abcd12","ZZ9999"};
        foreach(var plate in testPlates){
            Console.WriteLine($"{plate} → {(IsValidLicensePlate(plate)?"Valid":"Invalid")}");
        }
    }
}
 */