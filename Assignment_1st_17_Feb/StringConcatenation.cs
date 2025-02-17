/* using System;
using System.Text;

class Program {
    public static void Main() {
        int N = 10000;
        string str = "";
        for(int i=0;i<N;i++){
            str += "A";
        }
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<N;i++){
            sb.Append("A");
        }
        Console.WriteLine("String length: " +str.Length);
        Console.WriteLine("StringBuilder length: "+sb.Length);
    }
}
 */