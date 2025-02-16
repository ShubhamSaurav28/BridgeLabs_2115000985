/* using System;

class Program{
    public static int FindPeakElement(int[] nums){
        int left = 0;
		int right = nums.Length-1;
        while(left<right){
            int mid = left+(right-left)/2;
            if(nums[mid]>nums[mid+1]){
                right = mid; 
			}
            else{
                left = mid+1; 
			}
        }
        return left;
    }
    public static void Main(){
        int[] array = {1,3,20,4,1,0};
        int peakIndex = FindPeakElement(array);
        Console.WriteLine($"A peak element is at index: {peakIndex}, value: {array[peakIndex]}");
    }
}
 */