/* using System;

class SelectionSortAlgo{
    public static void SelectionSort(int[] scores){
        int n = scores.Length;
        for(int i=0;i<n-1;i++){
            int minIndex = i;
            for(int j=i+1;j<n;j++){
                if(scores[j]<scores[minIndex]){
                    minIndex = j;
				}
            }
            (scores[i],scores[minIndex]) = (scores[minIndex],scores[i]);
        }
    }
    public static void Main(){
        int[] examScores = {78,90,65,88,76};
        SelectionSort(examScores);
        Console.WriteLine("Sorted Exam Scores: "+string.Join(", ",examScores));
    }
}
 */