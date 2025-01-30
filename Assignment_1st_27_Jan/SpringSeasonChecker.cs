/* using System;

class SpringSeasonChecker{
    public bool CheckSpringSeason(int month, int day){
        if((month==3 && day>=20) || (month==6 && day<=20) || (month>3 && month<6)){
            return true;
		}
        return false;
    }
    public static void Main(){
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());
        if(CheckSpringSeason(month,day)){
            Console.WriteLine("It's a Spring Season.");
		}
        else{
            Console.WriteLine("Not a Spring Season.");
		}
    }
}
 */