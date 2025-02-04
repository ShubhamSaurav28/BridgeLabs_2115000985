/* using System;

class Vehicle{
    public static double RegistrationFee = 5000.0;
    public readonly string RegistrationNumber;
    private string ownerName;
    private string vehicleType;
    public Vehicle(string ownerName,string vehicleType,string registrationNumber){
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
        this.RegistrationNumber = registrationNumber;
    }
    public static void UpdateRegistrationFee(double newFee){
        RegistrationFee = newFee;
        Console.WriteLine($"The new registration fee is: ₹{RegistrationFee}");
    }
    public void DisplayRegistrationDetails(){
        if(this is Vehicle){
            Console.WriteLine($"Owner Name: {ownerName}");
            Console.WriteLine($"Vehicle Type: {vehicleType}");
            Console.WriteLine($"Registration Number: {RegistrationNumber}");
            Console.WriteLine($"Registration Fee: ₹{RegistrationFee}");
        }
        else{
            Console.WriteLine("This object is not an instance of the Vehicle class.");
        }
    }
}

class Program{
    public static void Main(string[] args){
        Vehicle.UpdateRegistrationFee(6000.0);
        Vehicle vehicle1 = new Vehicle("Shubham","Car","ABC123");
        Vehicle vehicle2 = new Vehicle("Sparsh","Bike","XYZ456");
        Console.WriteLine("\nVehicle 1 Registration Details:");
        vehicle1.DisplayRegistrationDetails();
        Console.WriteLine("\nVehicle 2 Registration Details:");
        vehicle2.DisplayRegistrationDetails();
        Vehicle.UpdateRegistrationFee(6500.0);
        Console.WriteLine("\nUpdated Vehicle 1 Registration Details:");
        vehicle1.DisplayRegistrationDetails();
        Console.WriteLine("\nUpdated Vehicle 2 Registration Details:");
        vehicle2.DisplayRegistrationDetails();
    }
}
 */