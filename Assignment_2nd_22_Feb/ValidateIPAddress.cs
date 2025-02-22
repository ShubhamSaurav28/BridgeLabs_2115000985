/* using System;
using System.Text.RegularExpressions;

class ValidateIPAddress{
    public static void Main(){
        string[] testIPs = {"192.168.1.1","255.255.255.255","256.100.50.25","10.0.0.1","123.456.78.90"};
        string pattern = @"\b(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\b";
        foreach(string ip in testIPs){
            Console.WriteLine($"{ip} → {(Regex.IsMatch(ip,pattern)?"Valid":"Invalid")}");
        }
    }
}
 */