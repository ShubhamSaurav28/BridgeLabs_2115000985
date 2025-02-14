/* using System;

class HeapSortAlgo{
    public static void HeapSort(int[] salaries){
        int n = salaries.Length;
        for(int i=n/2-1;i>=0;i--){
            Heapify(salaries, n, i);
		}
        for(int i=n-1;i>0;i--){
            (salaries[0],salaries[i]) = (salaries[i],salaries[0]);
            Heapify(salaries,i,0);
        }
    }
    public static void Heapify(int[] salaries,int n,int i){
        int largest = i;
		int left = 2*i+1;
		int right = 2*i+2;
        if(left<n && salaries[left]>salaries[largest]){
			largest = left;
		}
        if(right<n && salaries[right]>salaries[largest]){
			largest = right;
		}
        if(largest!=i){
            (salaries[i],salaries[largest]) = (salaries[largest],salaries[i]);
            Heapify(salaries,n,largest);
        }
    }

    public static void Main(){
        int[] jobSalaries = {50000,60000,45000,70000,55000};
        HeapSort(jobSalaries);
        Console.WriteLine("Sorted Salaries: "+string.Join(", ",jobSalaries));
    }
}
 */