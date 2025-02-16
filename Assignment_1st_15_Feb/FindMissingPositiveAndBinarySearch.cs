/* using System;

class Program{
    public static int FindFirstMissingPositive(int[] arr){
        int n = arr.Length;
        bool[] present = new bool[n+1];
        foreach(int num in arr){
            if(num>0 && num<=n){
                present[num] = true;
			}
        }
        for(int i=1;i<=n;i++){
            if(!present[i]){
                return i;
			}
        }
        return n+1;
    }
    public static int BinarySearch(int[] arr,int target){
        int left = 0;
		int right = arr.Length-1;
        while(left<=right){
            int mid = left+(right-left)/2;
            if(arr[mid]==target){
                return mid;
			}
            else if(arr[mid]<target){
                left = mid+1;
			}
            else{
                right = mid-1;
			}
        }
        return -1;
    }
    public static void Main(){
        int[] arr = {3,4,-1,1};
        int target = 4;
        int missing = FindFirstMissingPositive(arr);
        Console.WriteLine($"First missing positive number: {missing}");
        Array.Sort(arr);
        int index = BinarySearch(arr, target);
        if(index!=-1){
            Console.WriteLine($"Target {target} found at index: {index}");
		}
        else{
            Console.WriteLine("Target not found.");
		}
    }
}
 */