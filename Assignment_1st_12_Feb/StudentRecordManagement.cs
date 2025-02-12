/* using System;

class Student{
    public int RollNumber;
    public string Name;
    public int Age;
    public char Grade;
    public Student Next;
    public Student(int rollNumber,string name,int age,char grade){
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentList{
    private Student head;
    public void AddStudentAtBeginning(int rollNumber,string name,int age,char grade){
        Student newStudent = new Student(rollNumber,name,age,grade);
        newStudent.Next = head;
        head = newStudent;
        Console.WriteLine("Student added at the beginning.");
    }
    public void AddStudentAtEnd(int rollNumber,string name,int age,char grade){
        Student newStudent = new Student(rollNumber,name,age,grade);
        if(head==null){
            head = newStudent;
            return;
        }
        Student temp = head;
        while(temp.Next!=null){
            temp = temp.Next;
        }
        temp.Next = newStudent;
        Console.WriteLine("Student added at the end.");
    }
    public void AddStudentAtPosition(int position,int rollNumber,string name,int age,char grade){
        Student newStudent = new Student(rollNumber,name,age,grade);
        if(position<=0){
            Console.WriteLine("Invalid position.");
            return;
        }
        if(position==1){
            newStudent.Next = head;
            head = newStudent;
            Console.WriteLine("Student added at position "+position);
            return;
        }
        Student temp = head;
        for(int i=1;temp!=null && i<position-1;i++){
            temp = temp.Next;
        }
        if(temp==null){
            Console.WriteLine("Position out of bounds.");
            return;
        }
        newStudent.Next = temp.Next;
        temp.Next = newStudent;
        Console.WriteLine("Student added at position "+position);
    }
    public void DeleteStudent(int rollNumber){
        if(head==null){
            Console.WriteLine("List is empty.");
            return;
        }
        if(head.RollNumber==rollNumber){
            head = head.Next;
            Console.WriteLine("Student with Roll Number "+rollNumber+" deleted.");
            return;
        }
        Student temp=head;
		Student prev=null;
        while(temp!=null && temp.RollNumber!=rollNumber){
            prev = temp;
            temp = temp.Next;
        }
        if(temp==null){
            Console.WriteLine("Student not found.");
            return;
        }
        prev.Next = temp.Next;
        Console.WriteLine("Student with Roll Number "+rollNumber+" deleted.");
    }
    public void SearchStudent(int rollNumber){
        Student temp = head;
        while(temp!=null){
            if(temp.RollNumber==rollNumber){
                Console.WriteLine("Student Found: Roll No: "+temp.RollNumber+", Name: "+temp.Name+", Age: "+temp.Age+", Grade: "+temp.Grade);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found.");
    }
    public void UpdateStudentGrade(int rollNumber,char newGrade){
        Student temp = head;
        while(temp!=null){
            if(temp.RollNumber==rollNumber){
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated for Roll Number "+rollNumber);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found.");
    }
    public void DisplayStudents(){
        if(head==null){
            Console.WriteLine("No students in the list.");
            return;
        }
        Student temp = head;
        Console.WriteLine("Student Records:");
        while(temp!=null){
            Console.WriteLine($"Roll No: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
            temp = temp.Next;
        }
    }
}

class Program{
    public static void Main(){
        StudentList studentList = new StudentList();
        studentList.AddStudentAtBeginning(1,"Alice",20,'A');
        studentList.AddStudentAtEnd(2,"Bob",21,'B');
        studentList.AddStudentAtPosition(2,3,"Charlie",22,'C');
        studentList.DisplayStudents();
        Console.WriteLine("\nSearching for Roll Number 2:");
        studentList.SearchStudent(2);
        Console.WriteLine("\nUpdating Grade for Roll Number 3:");
        studentList.UpdateStudentGrade(3,'A');
        studentList.DisplayStudents();
        Console.WriteLine("\nDeleting Roll Number 1:");
        studentList.DeleteStudent(1);
        studentList.DisplayStudents();
    }
}
 */