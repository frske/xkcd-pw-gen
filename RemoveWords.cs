//Simple utility which removes all words which are less than 4 characters
//from a textfiles and writes all other words to another text file 
using System.Threading;
using System.Runtime.InteropServices;

public class RemoveWords
{
    public static void WordsRemover()
    {   
        //string of where the words are located and reads them
        string pathWords = "./wordlists/english.txt";
        string[] lines = File.ReadAllLines(pathWords);  
        
        string filteredWordsPath = "./wordlists/wordsn.txt";

        // tried some optimization, too complicated for now
        // int jumps = lines.Length / 4;
        // Console.WriteLine(jumps); 

        // string[] lines1 = new string[jumps];
        // string[] lines2 = new string[jumps];
        // string[] lines3 = new string[jumps];
        // string[] lines4 = new string[jumps];


        // //divides the array lines in 4 subarrays of the same length
        // Array.Copy(lines, 0, lines1, 0, jumps);
        // Array.Copy(lines, jumps, lines2, 0, jumps);
        // Array.Copy(lines, (jumps*2), lines3, 0, jumps);
        // Array.Copy(lines, (jumps*3), lines4, 0, jumps);


        //checks if words is less than 4, writes it to new file otherwise
        foreach (string line in lines)
        {
            if (line.Length > 4)
            {
                File.AppendAllText(filteredWordsPath, line + "\n"); 
            }
            else
            {
                continue; 
            }
        }
    }

    // public static void WordLessThanCheck(string[] word)
    // {
        
    // }
}

