/* using System;

class Patient{
    public static string HospitalName = "SS Hospital";
    private static int totalPatients = 0;
    public readonly int PatientID;
    private string name;
    private int age;
    private string ailment;
    public Patient(string name, int age, string ailment){
        this.name = name;
        this.age = age;
        this.ailment = ailment;
        this.PatientID = ++totalPatients;  // Assign a unique PatientID
    }
    public static void GetTotalPatients(){
        Console.WriteLine($"Total number of patients admitted: {totalPatients}");
    }
    public void DisplayPatientDetails(){
        if(this is Patient){
            Console.WriteLine($"Hospital Name: {HospitalName}");
            Console.WriteLine($"Patient ID: {PatientID}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Ailment: {ailment}");
        }
        else{
            Console.WriteLine("This object is not an instance of the Patient class.");
        }
    }
}

class Program{
    public static void Main(string[] args){
        Patient.GetTotalPatients();
        Patient patient1 = new Patient("Shubham",45,"Fever");
        Patient patient2 = new Patient("Sparsh",30,"Headache");
        Console.WriteLine("\nPatient 1 Details:");
        patient1.DisplayPatientDetails();
        Console.WriteLine("\nPatient 2 Details:");
        patient2.DisplayPatientDetails();
        Patient.GetTotalPatients();
    }
}
 */