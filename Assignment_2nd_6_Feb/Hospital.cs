/* using System;

public class Doctor{
    private string name;
    private List<Patient> patients;
    public Doctor(string name){
        this.name = name;
        this.patients = new List<Patient>();
    }
    public void Consult(Patient patient){
        Console.WriteLine($"{name} is consulting with {patient.GetName()}.");
        patient.ReceiveConsultation(this);
        this.patients.Add(patient);
    }
    public string GetName(){
        return name;
    }
    public List<Patient> GetPatients(){
        return patients;
    }
}

public class Patient{
    private string name;
    private List<Doctor> doctors;
    public Patient(string name){
        this.name = name;
        this.doctors = new List<Doctor>();
    }
    public void ReceiveConsultation(Doctor doctor){
        Console.WriteLine($"{name} is being treated by Dr. {doctor.GetName()}.");
        this.doctors.Add(doctor);
    }
    public string GetName(){
        return name;
    }
    public List<Doctor> GetDoctors(){
        return doctors;
    }
}

public class Hospital{
    private List<Doctor> doctors;
    private List<Patient> patients;
    public Hospital(){
        doctors = new List<Doctor>();
        patients = new List<Patient>();
    }
    public void AddDoctor(Doctor doctor){
        doctors.Add(doctor);
    }
    public void AddPatient(Patient patient){
        patients.Add(patient);
    }
    public void DisplayDoctorPatients(){
        foreach(var doctor in doctors){
            Console.WriteLine($"Dr. {doctor.GetName()} has the following patients:");
            foreach(var patient in doctor.GetPatients()){
                Console.WriteLine($"- {patient.GetName()}");
            }
        }
    }
    public void DisplayPatientDoctors(){
        foreach(var patient in patients){
            Console.WriteLine($"{patient.GetName()} is consulting the following doctors:");
            foreach(var doctor in patient.GetDoctors()){
                Console.WriteLine($"- Dr. {doctor.GetName()}");
            }
        }
    }
}

public class Program{
    public static void Main(string[] args){
        Hospital hospital = new Hospital();
        Doctor doctor1 = new Doctor("Rajesh Kumar");
        Doctor doctor2 = new Doctor("Priya Sharma");
        Patient patient1 = new Patient("Aarav Gupta");
        Patient patient2 = new Patient("Ishita Mehta");
        Patient patient3 = new Patient("Rohan Patel");
        hospital.AddDoctor(doctor1);
        hospital.AddDoctor(doctor2);
        hospital.AddPatient(patient1);
        hospital.AddPatient(patient2);
        hospital.AddPatient(patient3);
        doctor1.Consult(patient1);
        doctor2.Consult(patient1);
        doctor2.Consult(patient2);
        doctor1.Consult(patient3);
        hospital.DisplayDoctorPatients();
        hospital.DisplayPatientDoctors();
    }
}
 */