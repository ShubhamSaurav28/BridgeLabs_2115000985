/* using System;

interface IInsurable{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

abstract class Vehicle:IInsurable{
    protected string vehicleNumber;
    protected string type;
    protected double rentalRate;
    private string insurancePolicyNumber;
    public Vehicle(string vehicleNumber,string type,double rentalRate,string insurancePolicyNumber){
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
        this.insurancePolicyNumber = insurancePolicyNumber;
    }
    public abstract double CalculateRentalCost(int days);
    public virtual void DisplayDetails(){
        Console.WriteLine($"Vehicle Number: {vehicleNumber}, Type: {type}, Rental Rate: {rentalRate}");
    }
    public double CalculateInsurance(){
        return rentalRate*0.05;
    }
    public string GetInsuranceDetails(){
        return $"Insurance Policy Number: {insurancePolicyNumber} (Confidential)";
    }
}

class Car:Vehicle{
    public Car(string vehicleNumber,string type,double rentalRate,string insurancePolicyNumber):base(vehicleNumber,type,rentalRate,insurancePolicyNumber){}
    public override double CalculateRentalCost(int days){
        return rentalRate*days;
    }
}

class Bike:Vehicle{
    public Bike(string vehicleNumber,string type,double rentalRate,string insurancePolicyNumber):base(vehicleNumber,type,rentalRate,insurancePolicyNumber){}
    public override double CalculateRentalCost(int days){
        return rentalRate*days*0.9;
    }
}

class Truck:Vehicle{
    public Truck(string vehicleNumber,string type,double rentalRate,string insurancePolicyNumber):base(vehicleNumber,type,rentalRate,insurancePolicyNumber){}
    public override double CalculateRentalCost(int days){
        return rentalRate*days*1.2;
    }
}

class Program{
    public static void Main(string[] args){
        Car car = new Car("DL1234","Sedan",2000,"CAR-INS-456");
        Bike bike = new Bike("UP5678","Sports",1000,"BIKE-INS-789");
        Truck truck = new Truck("HR9012","Heavy",3000,"TRUCK-INS-012");
        ProcessVehicle(car,3);
        ProcessVehicle(bike,3);
        ProcessVehicle(truck,3);
    }
    public static void ProcessVehicle(Vehicle vehicle,int rentalDays){
        vehicle.DisplayDetails();
        double rentalCost = vehicle.CalculateRentalCost(rentalDays);
        double insuranceCost = vehicle.CalculateInsurance();
        Console.WriteLine($"Rental Cost for {rentalDays} days: {rentalCost}");
        Console.WriteLine($"Insurance Cost: {insuranceCost}");
        Console.WriteLine(vehicle.GetInsuranceDetails());
        Console.WriteLine();
    }
}
 */