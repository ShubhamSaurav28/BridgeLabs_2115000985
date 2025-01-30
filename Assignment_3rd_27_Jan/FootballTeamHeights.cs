using System;

class FootballTeamHeights{
    public static void Main(string[] args){
        int[] playerHeights = GenerateRandomHeights();
        Console.WriteLine("Shortest Height: " + GetShortestHeight(playerHeights));
        Console.WriteLine("Tallest Height: " + GetTallestHeight(playerHeights));
        Console.WriteLine("Mean Height: " + CalculateMeanHeight(playerHeights));
    }
    public static int[] GenerateRandomHeights(){
        Random randomGenerator = new Random();
        int[] playerHeights = new int[11];
        for(int index=0;index<playerHeights.Length;index++){
            playerHeights[index] = randomGenerator.Next(150, 251);
        }
        return playerHeights;
    }
    public static int GetShortestHeight(int[] playerHeights){
        int shortestHeight = playerHeights[0];
        foreach(int height in playerHeights){
            if(height<shortestHeight){
                shortestHeight = height;
			}
        }
        return shortestHeight;
    }
    public static int GetTallestHeight(int[] playerHeights){
        int tallestHeight = playerHeights[0];
        foreach(int height in playerHeights){
            if(height>tallestHeight){
                tallestHeight = height;
			}
        }
        return tallestHeight;
    }
    public static double CalculateMeanHeight(int[] playerHeights){
        int totalHeight = 0;
        foreach(int height in playerHeights){
            totalHeight += height;
        }
        return totalHeight/(double)playerHeights.Length;
    }
}