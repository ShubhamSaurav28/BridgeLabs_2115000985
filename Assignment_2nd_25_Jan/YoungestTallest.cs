/* using System;

class YoungestTallest{
    public static void Main(){
        int[] age = new int[3];
        double[] height = new double[3];
        for(int i=0;i<3;i++){
            Console.Write("Enter age of friend {0}: ", i + 1);
            age[i] = int.Parse(Console.ReadLine());
            Console.Write("Enter height of friend {0}: ", i + 1);
            height[i] = double.Parse(Console.ReadLine());
        }
        int youngestIndex = 0;
        int tallestIndex = 0;
        for(int i=1;i<3;i++){
            if (age[i]<age[youngestIndex]){
				youngestIndex = i;
			}
            if (height[i]>height[tallestIndex]){
				tallestIndex = i;
			}
        }
        Console.WriteLine($"The youngest is friend {youngestIndex + 1} with age {age[youngestIndex]}.");
        Console.WriteLine($"The tallest is friend {tallestIndex + 1} with height {height[tallestIndex]}.");
    }
}
  */