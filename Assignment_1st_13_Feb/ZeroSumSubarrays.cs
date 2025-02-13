/* using System;

class ZeroSumSubarrays{
    public static int CountZeroSumSubarrays(int[] arr){
        Dictionary<int,int> map = new Dictionary<int,int>();
        int sum = 0;
		int count = 0;
        map[0] = 1;
        foreach(int num in arr){
            sum += num;
            if(map.ContainsKey(sum)){
                count += map[sum];
			}
            if(map.ContainsKey(sum)){
                map[sum]++;
			}
            else{
                map[sum] = 1;
			}
        }
        return count;
    }
    public static void Main(){
        int[] arr = {3,4,-7,3,1,3,1,-4,-2,-2};
        Console.WriteLine(CountZeroSumSubarrays(arr));
    }
}
 */