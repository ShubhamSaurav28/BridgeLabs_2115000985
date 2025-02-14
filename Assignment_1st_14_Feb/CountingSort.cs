/* using System;

class CountingSortAlgo{
    public static void CountingSort(int[] ages,int maxAge){
        int[] count = new int[maxAge+1];
        int[] output = new int[ages.Length];
        foreach(int age in ages){
            count[age]++;
		}
        for(int i=1;i<=maxAge;i++){
            count[i] += count[i-1];
		}
        for(int i=ages.Length-1;i>=0;i--){
            output[count[ages[i]]-1] = ages[i];
            count[ages[i]]--;
        }
        Array.Copy(output,ages,ages.Length);
    }

    public static void Main(){
        int[] studentAges = {15,12,18,14,10,16,17,13};
        CountingSort(studentAges,18);
        Console.WriteLine("Sorted Ages: "+string.Join(", ",studentAges));
    }
}
 */