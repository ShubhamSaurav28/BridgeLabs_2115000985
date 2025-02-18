/* using System;
using System.Collections.Generic;

abstract class JobRole{
    public string RoleName{get;set;}
    public JobRole(string roleName) => RoleName = roleName;
}

class SoftwareEngineer:JobRole{ 
	public SoftwareEngineer():base("Software Engineer"){} 
}

class DataScientist:JobRole{
	public DataScientist():base("Data Scientist"){}
}

class Resume<T> where T:JobRole{
    public T Job{get;set;}
    public Resume(T job) => Job = job;
}

class ScreeningPipeline<T> where T:JobRole{
    private List<Resume<T>> resumes = new List<Resume<T>>();
    public void AddResume(Resume<T> resume) => resumes.Add(resume);
    public void DisplayResumes(){
        foreach(var resume in resumes){
            Console.WriteLine($"Processing Resume for {resume.Job.RoleName}");
		}
    }
}

class Program{
    public static void Main(){
        var softwareResume = new Resume<SoftwareEngineer>(new SoftwareEngineer());
        var pipeline = new ScreeningPipeline<SoftwareEngineer>();
        pipeline.AddResume(softwareResume);
        pipeline.DisplayResumes();
    }
} */