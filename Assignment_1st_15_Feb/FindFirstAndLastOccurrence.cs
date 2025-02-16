/* using System;

class Program{
    public static int FindFirstOccurrence(int[] arr,int target){
        int left = 0;
		int right = arr.Length-1;
		int	firstIndex = -1;
        while(left<=right){
            int mid = left+(right-left)/2;
            if(arr[mid]==target){
                firstIndex = mid;
                right = mid-1;
            }
            else if(arr[mid]<target){
                left = mid+1;
			}
            else{
                right = mid-1;
        }
        return firstIndex;
    }
    public static int FindLastOccurrence(int[] arr,int target){
        int left = 0;
		int right = arr.Length-1;
		int lastIndex = -1;
        while(left<=right){
            int mid = left+(right-left)/2;
            if(arr[mid]==target){
                lastIndex = mid;
                left = mid+1;
            }
            else if(arr[mid]<target){
                left = mid+1;
			}
            else{ 
				right = mid-1;
			}
        }
        return lastIndex;
    }
    public static void Main(){
        int[] arr = {1,2,2,2,3,4,5};
        int target = 2;
        int first = FindFirstOccurrence(arr,target);
        int last = FindLastOccurrence(arr,target);
        if(first==-1){
            Console.WriteLine("Element not found.");
		}
        else{
            Console.WriteLine($"First occurrence: {first}, Last occurrence: {last}");
		}
    }
}
 */