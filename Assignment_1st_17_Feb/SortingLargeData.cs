/* using System;

class Program {
    public static void BubbleSort(int[] arr){
        int n = arr.Length;
        for(int i=0;i<n-1;i++){
            for(int j=0;j<n-i-1;j++){
                if(arr[j]>arr[j+1]){
                    (arr[j],arr[j+1]) = (arr[j+1],arr[j]);
                }
            }
        }
    }
	public static void MergeSort(int[] arr,int left,int right) {
        if(left>=right){
			return;
		}
        int mid = (left+right)/2;
        MergeSort(arr,left,mid);
        MergeSort(arr,mid+1,right);
        Merge(arr,left,mid,right);
    }
    public static void Merge(int[] arr,int left,int mid,int right) {
        int[] temp = new int[right-left+1];
        int i = left;
		int j = mid+1;
		int k = 0;
        while(i<=mid && j<=right){
            temp[k++] = arr[i]<arr[j]?arr[i++]:arr[j++];
        }
        while(i<=mid){
			temp[k++] = arr[i++];
		}
        while(j<=right){
			temp[k++] = arr[j++];
		}
        Array.Copy(temp,0,arr,left,temp.Length);
    }
	public static void QuickSort(int[] arr,int low,int high) {
        if(low<high) {
            int pivotIndex = Partition(arr,low,high);
            QuickSort(arr,low,pivotIndex-1);
            QuickSort(arr,pivotIndex+1,high);
        }
    }
    public static int Partition(int[] arr,int low,int high) {
        int pivot = arr[high];
		int i = low-1;
        for(int j=low;j<high;j++){
            if(arr[j]<pivot){
                i++;
                (arr[i],arr[j]) = (arr[j],arr[i]);
            }
        }
        (arr[i+1],arr[high]) = (arr[high],arr[i+1]);
        return i+1;
    }
    public static void Main() {
        int[] arr = {5,3,8,4,2};
        QuickSort(arr,0,arr.Length-1);
        Console.WriteLine(string.Join(", ",arr));
        MergeSort(arr,0,arr.Length-1);
        Console.WriteLine(string.Join(", ",arr));
        BubbleSort(arr);
        Console.WriteLine(string.Join(", ",arr));
    }
}
 */