/* using System;

class BubbleSortAlgo{
    public static void BubbleSort(int[] marks){
        int n = marks.Length;
        bool swapped;
        for(int i=0;i<n-1;i++){
            swapped = false;
            for(int j=0;j<n-i-1;j++){
                if(marks[j]>marks[j+1]){
                    (marks[j],marks[j+1]) = (marks[j+1],marks[j]);
                    swapped = true;
                }
            }
            if(!swapped){
				break;
			}
        }
    }
    public static void Main(){
        int[] marks = {75,60,89,45,95};
        BubbleSort(marks);
        Console.WriteLine("Sorted Marks: "+string.Join(", ",marks));
    }
}
 */