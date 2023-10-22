using System.IO;
using System.Diagnostics;
public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Simple xkcd inspired password generator");
        Console.WriteLine("https://xkcd.com/936/"); 
        Console.WriteLine("Press any key to continue"); 
        Console.ReadKey();
        Console.Clear();

        //RemoveWords.WordsRemover(); 

        Console.Write("How many words should your password contain (default 4): ");
        int option = 4;
        option = Convert.ToInt32(Console.ReadLine());
        
        //typecheck

        Random random =  new Random(); 
        string filePath = "./wordlists/wordsn.txt"; //filepath of location of words
        string[] lines = File.ReadAllLines(filePath); //loads file into memory ~15mb
        int[] randomValues = new int[option]; //array to hold random values, as many as the user requested

        for (int i = 0; i < option; i++) //generate random values and puts them into the array
        {
            randomValues[i] = random.Next(0, lines.Length);
            Debug.WriteLine("index " + i + ": " + randomValues[i]);
            Console.Write(lines[randomValues[i]] + "-");
        }
    }
}