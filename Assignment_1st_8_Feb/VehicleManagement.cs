/* using System;

interface IRefuelable{
    void Refuel();
}

class Vehicle{
    protected int maxSpeed;
    protected string model;
    public Vehicle(int maxSpeed,string model){
        this.maxSpeed = maxSpeed;
        this.model = model;
    }
    public void DisplayInfo(){
        Console.WriteLine($"Model: {this.model}, Max Speed: {this.maxSpeed} km/h");
    }
}

class ElectricVehicle:Vehicle{
    private int batteryCapacity;
    public ElectricVehicle(int maxSpeed,string model,int batteryCapacity):base(maxSpeed,model){
        this.batteryCapacity = batteryCapacity;
    }
    public void Charge(){
        Console.WriteLine($"{this.model} is charging. Battery Capacity: {this.batteryCapacity} kWh");
    }
}

class PetrolVehicle:Vehicle,IRefuelable{
    private int fuelCapacity;
    public PetrolVehicle(int maxSpeed,string model,int fuelCapacity):base(maxSpeed,model){
        this.fuelCapacity = fuelCapacity;
    }
    public void Refuel(){
        Console.WriteLine($"{this.model} is refueling. Fuel Capacity: {this.fuelCapacity} liters");
    }
}

class Program{
    public static void Main(){
        Vehicle electricCar = new ElectricVehicle(150,"Tesla",100);
        Vehicle petrolCar = new PetrolVehicle(200,"Alto800",60);
        electricCar.DisplayInfo();
        ((ElectricVehicle)electricCar).Charge();
        petrolCar.DisplayInfo();
        ((PetrolVehicle)petrolCar).Refuel();
    }
}
 */