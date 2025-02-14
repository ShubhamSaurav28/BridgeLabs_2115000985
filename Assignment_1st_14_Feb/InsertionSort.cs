/* using System;

class InsertionSortAlgo{
    public static void InsertionSort(int[] ids){
        int n = ids.Length;
        for(int i=1;i<n;i++){
            int key = ids[i];
            int j = i-1;
            while (j>=0 && ids[j]>key){
                ids[j+1] = ids[j];
                j--;
            }
            ids[j+1] = key;
        }
    }

    public static void Main(){
        int[] employeeIds = {104,102,109,101,105};
        InsertionSort(employeeIds);
        Console.WriteLine("Sorted Employee IDs: "+string.Join(", ",employeeIds));
    }
}
 */