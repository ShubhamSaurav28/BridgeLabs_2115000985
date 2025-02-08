/* using System;

class Course{
    protected string courseName;
    protected int durationInWeeks;
    public Course(string courseName,int durationInWeeks){
        this.courseName = courseName;
        this.durationInWeeks = durationInWeeks;
    }
    public virtual void DisplayDetails(){
        Console.WriteLine($"Course Name: {this.courseName}, Duration: {this.durationInWeeks} weeks");
    }
}

class OnlineCourse:Course{
    protected string platform;
    protected bool isRecorded;
    public OnlineCourse(string courseName,int durationInWeeks,string platform,bool isRecorded):base(courseName,durationInWeeks){
        this.platform = platform;
        this.isRecorded = isRecorded;
    }
    public override void DisplayDetails(){
        Console.WriteLine($"Course Name: {this.courseName}, Duration: {this.durationInWeeks} weeks, Platform: {this.platform}, Is Recorded: {this.isRecorded}");
    }
}

class PaidOnlineCourse:OnlineCourse{
    private double fee;
    private double discount;
    public PaidOnlineCourse(string courseName,int durationInWeeks,string platform,bool isRecorded,double fee,double discount):base(courseName,durationInWeeks,platform,isRecorded){
        this.fee = fee;
        this.discount = discount;
    }
    public override void DisplayDetails(){
        double finalPrice = this.fee-(this.fee*this.discount/100);
        Console.WriteLine($"Course Name: {this.courseName}, Duration: {this.durationInWeeks} weeks, Platform: {this.platform}, Fee: {this.fee}, Discount: {this.discount}%");
        Console.WriteLine($"Final Price after Discount: {finalPrice}");
    }
}

class Program{
    public static void Main(){
        Course basicCourse = new Course("Introduction to Programming",6);
        basicCourse.DisplayDetails();
        OnlineCourse onlineCourse = new OnlineCourse("Data Science",12,"Udemy",true);
        onlineCourse.DisplayDetails();
        PaidOnlineCourse paidCourse = new PaidOnlineCourse("Advanced C#",8,"Coursera",true,500.00,20.0);
        paidCourse.DisplayDetails();
    }
}
 */