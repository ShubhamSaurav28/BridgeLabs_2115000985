/* using System;

class QuickSortAlgo{
    public static void QuickSort(int[] prices,int low,int high){
        if(low<high){
            int pivotIndex = Partition(prices,low,high);
            QuickSort(prices,low,pivotIndex-1);
            QuickSort(prices,pivotIndex+1,high);
        }
    }
    public static int Partition(int[] prices,int low,int high){
        int pivot = prices[high];
        int i = low-1;
        for (int j=low;j<high;j++){
            if (prices[j]<pivot){
                i++;
                (prices[i],prices[j]) = (prices[j],prices[i]);
            }
        }
        (prices[i+1],prices[high]) = (prices[high],prices[i+1]);
        return i+1;
    }
    public static void Main(){
        int[] productPrices = {800,100,600,400,700};
        QuickSort(productPrices,0,productPrices.Length-1);
        Console.WriteLine("Sorted Product Prices: "+string.Join(", ",productPrices));
    }
}
 */