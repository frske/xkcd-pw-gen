using System.IO;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Simple xkcd inspired password generator");
        Console.WriteLine("Press any key to continue"); 
        Console.ReadKey();
        Console.Clear();

        string filePath = "./wordsn.txt";
        string[] lines = File.ReadAllLines(filePath); 

        Random random =  new Random(); 

        for (var i = 0; i < 4; i++)
        {
            
        }

        int rndVal1 = random.Next(0, lines.Length); 
        int rndVal2 = random.Next(0, lines.Length);
        int rndVal3 = random.Next(0, lines.Length); 
        int rndVal4 = random.Next(0, lines.Length);

        Console.WriteLine(lines[rndVal1] + "-" + lines[rndVal2] + "-" + lines[rndVal3] + "-" + lines[rndVal4]);

        //string line = File.ReadLines(filePath).ElementAt(36);
        //Console.WriteLine(line);

    }
}