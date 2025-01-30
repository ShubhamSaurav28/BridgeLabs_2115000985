/* using System;

class NumberGuessingGame{
    public static void Main(){
        int low = 1;
		int high = 100;
		itn guess;
        string feedback;
        Console.WriteLine("Think of a number between 1 and 100.");
        while(true){
            guess = (low+high)/2;
            Console.WriteLine($"Is your number {guess}? (Enter 'high', 'low', or 'correct')");
            feedback = Console.ReadLine().ToLower();
            if(feedback=="correct"){
                Console.WriteLine("Hooray! The computer guessed your number.");
                break;
            }
            else if(feedback=="high"){
                high = guess - 1;
			}
            else if(feedback=="low"){
                low = guess + 1;
			}
        }
    }
} */