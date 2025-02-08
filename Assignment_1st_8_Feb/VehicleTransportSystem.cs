/* using System;

class Vehicle{
    protected int maxSpeed;
    protected string fuelType;
    public Vehicle(int maxSpeed,string fuelType){
        this.maxSpeed = maxSpeed;
        this.fuelType = fuelType;
    }
    public virtual void DisplayInfo(){
        Console.WriteLine($"Vehicle -> Max Speed: {this.maxSpeed} km/h, Fuel Type: {this.fuelType}");
    }
}

class Motorcycle:Vehicle{
    private bool hasSidecar;
    public Motorcycle(int maxSpeed,string fuelType,bool hasSidecar):base(maxSpeed,fuelType){
        this.hasSidecar = hasSidecar;
    }
    public override void DisplayInfo(){
        Console.WriteLine($"Motorcycle -- Max Speed: {this.maxSpeed} km/h, Fuel Type: {this.fuelType}, Has Sidecar: {this.hasSidecar}");
    }
}

class Car:Vehicle{
    private int seatCapacity;
    public Car(int maxSpeed,string fuelType,int seatCapacity):base(maxSpeed,fuelType){
        this.seatCapacity = seatCapacity;
    }
    public override void DisplayInfo(){
        Console.WriteLine($"Car -- Max Speed: {this.maxSpeed} km/h, Fuel Type: {this.fuelType}, Seat Capacity: {this.seatCapacity}");
    }
}

class Truck:Vehicle{
    private int payloadCapacity;
    public Truck(int maxSpeed,string fuelType,int payloadCapacity):base(maxSpeed,fuelType){
        this.payloadCapacity = payloadCapacity;
    }
    public override void DisplayInfo(){
        Console.WriteLine($"Truck -- Max Speed: {this.maxSpeed} km/h, Fuel Type: {this.fuelType}, Payload Capacity: {this.payloadCapacity} kg");
    }
}

class Program{
    public static void Main(){
        Vehicle[] vehicles = new Vehicle[]{
            new Car(200,"Petrol",5),
            new Truck(150,"Diesel",10000),
            new Motorcycle(100,"Petrol",false)
        };
        foreach(var vehicle in vehicles){
            vehicle.DisplayInfo();
        }
    }
}
 */