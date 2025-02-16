/* using System;
using System.Text;
using System.Diagnostics;

class Program{
    public static void ComparePerformance(){
        int iterations = 10000;
        string testString = "Hello";
        Stopwatch sw1 = Stopwatch.StartNew();
        string result = "";
        for(int i=0;i<iterations;i++){
            result += testString;
        }
        sw1.Stop();
        Console.WriteLine($"String concatenation time: {sw1.ElapsedMilliseconds} ms");
        Stopwatch sw2 = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<iterations;i++){
            sb.Append(testString);
        }
        string finalResult = sb.ToString();
        sw2.Stop();
        Console.WriteLine($"StringBuilder time: {sw2.ElapsedMilliseconds} ms");
    }
    public static void Main(){
        ComparePerformance();
    }
}
 */