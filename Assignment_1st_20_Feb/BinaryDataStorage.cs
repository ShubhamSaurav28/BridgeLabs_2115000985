/* using System;
using System.IO;

class BinaryDataStorage{
    public static void Main(){
        string filePath = "students.dat";
        try{
            using(BinaryWriter writer = new BinaryWriter(File.Open(filePath,FileMode.Create))){
                writer.Write(101);
                writer.Write("Shubham");
                writer.Write(3.8);
            }
            using(BinaryReader reader = new BinaryReader(File.Open(filePath,FileMode.Open))){
                int rollNumber = reader.ReadInt32();
                string name = reader.ReadString();
                double gpa = reader.ReadDouble();
                Console.WriteLine($"Roll: {rollNumber}, Name: {name}, GPA: {gpa}");
            }
        }
        catch(Exception ex){
            Console.WriteLine("Error: "+ex.Message);
        }
    }
}
 */