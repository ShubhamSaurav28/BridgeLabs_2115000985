/* using System;

interface IGPS{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

abstract class Vehicle{
    protected string vehicleId;
    protected string driverName;
    protected double ratePerKm;
    public Vehicle(string vehicleId,string driverName,double ratePerKm){
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }
    public abstract double CalculateFare(double distance);
    public void GetVehicleDetails(){
        Console.WriteLine($"Vehicle ID: {this.vehicleId}, Driver: {this.driverName}");
    }
}

class Car : Vehicle{
    public Car(string vehicleId,string driverName,double ratePerKm):base(vehicleId,driverName,ratePerKm){}
    public override double CalculateFare(double distance){
        return this.ratePerKm*distance;
    }
}

class Bike : Vehicle{
    public Bike(string vehicleId,string driverName,double ratePerKm):base(vehicleId,driverName,ratePerKm){}
    public override double CalculateFare(double distance){
        return this.ratePerKm*distance*0.9;
    }
}

class Program{
    public static void Main(string[] args){
        List<Vehicle> vehicles = new List<Vehicle>{
            new Car("DL5678","Rahul",12),
            new Bike("UP4321","Amit",8)
        };
        foreach(Vehicle vehicle in vehicles){
            vehicle.GetVehicleDetails();
            Console.WriteLine($"Fare for 10 km: {vehicle.CalculateFare(10)}");
        }
    }
}
 */