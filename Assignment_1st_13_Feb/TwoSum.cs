/* using System;

class TwoSum{
    public static int[] FindTwoSum(int[] arr,int target){
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i=0;i<arr.Length;i++){
            int complement = target-arr[i];
            if(map.ContainsKey(complement)){
                return new int[] {map[complement],i};
			}
            map[arr[i]] = i;
        }
        return new int[] {-1,-1};
    }
    public static void Main(){
        int[] arr = {2,7,11,15};
        int target = 9;
        int[] result = FindTwoSum(arr,target);
        Console.WriteLine(string.Join(" ",result));
    }
}
 */