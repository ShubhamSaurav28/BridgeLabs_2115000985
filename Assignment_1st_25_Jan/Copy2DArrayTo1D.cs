/* using System;

class Copy2DArrayTo1D{
    public static void Main(){
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        int[] array = new int[rows*cols];
        int index = 0;
        Console.WriteLine("Enter the elements of the 2D array:");
        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                matrix[i,j] = int.Parse(Console.ReadLine());
                array[index++] = matrix[i,j];
            }
        }
        Console.WriteLine("1D Array:");
        foreach(int element in array){
            Console.WriteLine(element);
        }
    }
}
 */