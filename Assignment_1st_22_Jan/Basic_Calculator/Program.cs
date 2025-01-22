using System;

class BasicCalculator {
    public static void Main() {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
		Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {number1:f2} and {number2:f2} is {number1 + number2:f2}, {number1 - number2:f2}, {number1 * number2:f2}, and {number1 / number2:f2}");
    }
}
