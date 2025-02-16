/* using System;

class Program{
    public static int FindRotationPoint(int[] nums){
        int left = 0;
		int right = nums.Length-1;
        while(left<right){
            int mid = left+(right-left)/2;
            if(nums[mid]>nums[right]){
                left = mid+1;
			}
            else{
                right = mid;
			}
        }
        return left;
    }
    public static void Main(){
        int[] rotatedArray = {4,5,6,7,0,1,2};
        int rotationPoint = FindRotationPoint(rotatedArray);
        Console.WriteLine($"The rotation point (index of smallest element) is: {rotationPoint}");
    }
}
 */