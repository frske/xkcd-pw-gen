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

        int option = 4;

        bool validInput = false; 

        while (!validInput)
        {   
            Console.Clear();
            Console.Write("How many words should your password contain (default 4): ");
            var input = Console.ReadLine();

            validInput = int.TryParse(input, out option);

            if (option <= 0 || validInput == false)
            {   
                Console.Clear();
                Console.WriteLine("ERROR: INVALID INPUT");
                Console.WriteLine("Press any key to continue"); 
                validInput = false;
                Console.ReadKey();
            }
        }
        
        Random random =  new Random(); 
        string filePath = "./wordlists/wordsn.txt"; //filepath of location of words
        string[] lines = File.ReadAllLines(filePath); //loads file into memory ~15mb
        int[] randomValues = new int[option]; //array to hold random values, as many as the user requested

        for (int i = 0; i < option; i++) 
        {
            randomValues[i] = random.Next(0, lines.Length); //generate random values and puts them into the array
            Debug.WriteLine("index " + i + ": " + randomValues[i]); //debug output if the numbers are generating correctly
            Console.Write(lines[randomValues[i]]); //writes the random words
            if (i < (option - 1)) //adds the "-" in between words
            {
                Console.Write("-");
            }
            
        }
    }
}