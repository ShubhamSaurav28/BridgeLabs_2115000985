/* using System;

class Device{
    protected string deviceId;
    protected string status;
    public Device(string deviceId,string status){
        this.deviceId = deviceId;
        this.status = status;
    }
    public virtual void DisplayStatus(){
        Console.WriteLine($"Device ID: {this.deviceId}, Status: {this.status}");
    }
}

class Thermostat:Device{
    private int temperatureSetting;
    public Thermostat(string deviceId,string status,int temperatureSetting):base(deviceId,status){
        this.temperatureSetting = temperatureSetting;
    }
    public override void DisplayStatus(){
        Console.WriteLine($"Device ID: {this.deviceId}, Status: {this.status}, Temperature Setting: {this.temperatureSetting}°C");
    }
}

class Program{
    public static void Main(){
        Thermostat thermostatDevice = new Thermostat("2823445","Active",23);
        thermostatDevice.DisplayStatus();
    }
}
 */