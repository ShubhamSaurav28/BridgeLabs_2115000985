/* using System;

class PairWithSum{
    public static bool HasPairWithSum(int[] arr,int target){
        HashSet<int> set = new HashSet<int>();
        foreach(int num in arr){
            if(set.Contains(target-num)){
                return true;
			}
            set.Add(num);
        }
        return false;
    }
    public static void Main(){
        int[] arr = {10,15,3,7};
        int target = 17;
        Console.WriteLine(HasPairWithSum(arr,target));
    }
}
 */