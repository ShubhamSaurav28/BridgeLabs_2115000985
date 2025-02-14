/* using System;

class MergeSortAlgo{
    public static void MergeSort(int[] prices,int left,int right){
        if(left<right){
            int mid = (left+right)/2;
            MergeSort(prices,left,mid);
            MergeSort(prices,mid+1,right);
            Merge(prices,left,mid,right);
        }
    }
    public static void Merge(int[] prices,int left,int mid,int right){
        int n1 = mid-left+1;
		int n2 = right-mid;
        int[] leftArr = new int[n1];
		int[] rightArr = new int[n2];
        for(int i=0;i<n1;i++){
			leftArr[i] = prices[left+i];
		}
        for(int j=0;j<n2;j++){
			rightArr[j] = prices[mid+1+j];
		}
        int i1 = 0;
		int j1 = 0;
		int k = left;
        while(i1<n1 && j1<n2){
            prices[k++] = (leftArr[i1]<=rightArr[j1])?leftArr[i1++]:rightArr[j1++];
        }
        while (i1<n1){
			prices[k++] = leftArr[i1++];
		}
        while (j1<n2){
			prices[k++] = rightArr[j1++];
		}
    }
    public static void Main(){
        int[] bookPrices = {500,200,300,100,400};
        MergeSort(bookPrices,0,bookPrices.Length-1);
        Console.WriteLine("Sorted Book Prices: "+string.Join(", ",bookPrices));
    }
}
 */