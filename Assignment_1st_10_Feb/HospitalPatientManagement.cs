/* using System;

interface IMedicalRecord{
    void AddRecord(string record);
    void ViewRecords();
}

abstract class Patient{
    protected int patientId;
    protected string name;
    protected int age;
    public Patient(int patientId,string name,int age){
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }
    public abstract double CalculateBill();
    public void GetPatientDetails(){
        Console.WriteLine($"Patient ID: {this.patientId}, Name: {this.name}, Age: {this.age}");
    }
}

class InPatient:Patient{
    private double roomCharge;
    public InPatient(int patientId,string name,int age,double roomCharge):base(patientId,name,age){
        this.roomCharge = roomCharge;
    }
    public override double CalculateBill(){
        return this.roomCharge*5;
    }
}

class OutPatient:Patient{
    private double consultationFee;
    public OutPatient(int patientId,string name,int age,double consultationFee):base(patientId,name,age){
        this.consultationFee = consultationFee;
    }
    public override double CalculateBill(){
        return this.consultationFee;
    }
}

class Program{
    public static void Main(string[] args){
        List<Patient> patients = new List<Patient>{
            new InPatient(1,"Vikas",45,1000),
            new OutPatient(2,"Sneha",30,500)
        };
        foreach(Patient patient in patients){
            patient.GetPatientDetails();
            Console.WriteLine($"Bill Amount: {patient.CalculateBill()}");
        }
    }
}
 */