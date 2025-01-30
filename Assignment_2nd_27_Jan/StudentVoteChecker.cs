/* using System;

class StudentVoteChecker{
    public static bool CanStudentVote(int age){
        if(age<0){
            return false;
        }
        return age >= 18;
    }
    public static void Main(string[] args){
        int[] studentAges = new int[10];
        for(int i=0;i<studentAges.Length;i++){
            Console.Write($"Enter age of student {i+1}: ");
            studentAges[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i=0;i<studentAges.Length;i++){
            bool canVote = CanStudentVote(studentAges[i]);
            if(canVote){
                Console.WriteLine($"Student {i+1} with age {studentAges[i]} can vote.");
            }
            else
            {
                Console.WriteLine($"Student {i+1} with age {studentAges[i]} cannot vote.");
            }
        }
    }
}
 */