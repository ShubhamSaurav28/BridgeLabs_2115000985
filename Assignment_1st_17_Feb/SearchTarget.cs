/* using System;

class Program {
    public static int LinearSearch(int[] arr,int target) {
        for(int i=0;i<arr.Length;i++){
            if(arr[i]==target){
                return i;
			}
        }
        return -1;
    }
	public static int BinarySearch(int[] arr,int target) {
        int left = 0;
		int right = arr.Length-1;
        while(left<=right){
            int mid = left+(right-left)/2;
            if(arr[mid]==target){
				return mid;
			}
            if(arr[mid]<target){
				left = mid+1;
			}
            else{
				right = mid-1;
			}
        }
        return -1;
    }

    public static void Main() {
        int[] arr = {1,3,5,7,9,11};
        int target = 7;
        int result1 = BinarySearch(arr,target);
        Console.WriteLine(result1!=-1?$"Found at index {result1}" : "Not found");
        int result2 = LinearSearch(arr,target);
        Console.WriteLine(result2!=-1?$"Found at index {result2}" : "Not found");
    }
}
 */