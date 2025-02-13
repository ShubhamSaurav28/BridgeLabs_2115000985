/* using System;

class LongestConsecutive{
    public static int FindLongestConsecutive(int[] arr){
        HashSet<int> set = new HashSet<int>(arr);
        int longest = 0;
        foreach(int num in arr){
            if(!set.Contains(num-1)){
                int currentNum = num;
				int streak = 1;
                while(set.Contains(currentNum+1)){
                    currentNum++;
                    streak++;
                }
                longest = Math.Max(longest,streak);
            }
        }
        return longest;
    }
    public static void Main(){
        int[] arr = {100,4,200,1,3,2};
        Console.WriteLine(FindLongestConsecutive(arr));
    }
}
 */