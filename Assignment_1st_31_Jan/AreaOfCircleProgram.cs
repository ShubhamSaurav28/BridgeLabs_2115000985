//using System;

//class Circle{
//    private double radius;
//    public void SetRadius(double radius){
//        if(radius>0){
//            this.radius = radius;
//        }
//        else{
//            Console.WriteLine("Radius must be positive.");
//        }
//    }
//    public double GetRadius(){
//        return radius;
//    }
//    public double CalculateArea(){
//        return Math.PI*radius*radius;
//    }
//    public double CalculateCircumference(){
//        return 2*Math.PI*radius;
//    }
//    public void DisplayDetails(){
//        Console.WriteLine($"Circle Radius: {GetRadius()}");
//        Console.WriteLine($"Area: {CalculateArea():f2}");
//        Console.WriteLine($"Circumference: {CalculateCircumference():f2}");
//    }
//}

//class Program{
//    public static void Main(){
//        Circle circle = new Circle();
//        circle.SetRadius(5);
//        circle.DisplayDetails();
//    }
//}
