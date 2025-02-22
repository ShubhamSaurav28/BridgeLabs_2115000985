/* using System;
using System.Text.RegularExpressions;

class ValidateCreditCard{
    public static void Main(){
        string[] testCards = {"4111111111111111","5500000000000004","4012888888881881","5111111111111118","1234567812345678"};
        string visaPattern = @"^4\d{15}$";
        string masterCardPattern = @"^5\d{15}$";
        foreach(string card in testCards){
            if(Regex.IsMatch(card,visaPattern)){
                Console.WriteLine($"{card} → Valid Visa Card");
			}
            else if(Regex.IsMatch(card, masterCardPattern)){
                Console.WriteLine($"{card} → Valid MasterCard");
			}
            else{
                Console.WriteLine($"{card} → Invalid");
			}
        }
    }
}
 */