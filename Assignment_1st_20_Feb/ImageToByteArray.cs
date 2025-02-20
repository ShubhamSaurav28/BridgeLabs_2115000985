/* using System;
using System.IO;

class ImageToByteArray{
    public static void Main(){
        string imagePath = "image.jpg";
        string outputImagePath = "output.jpg";
        try{
            byte[] imageBytes = File.ReadAllBytes(imagePath);
            File.WriteAllBytes(outputImagePath,imageBytes);
            Console.WriteLine("Image conversion successful.");
        }
        catch(Exception ex){
            Console.WriteLine("Error: "+ex.Message);
        }
    }
}
 */