using System.Runtime.InteropServices;

public class RemoveWords
{
    public static void WordsRemover()
    {   
        //string of where the words are located and reads them
        string pathWords = "./wordlists/wordsduped.txt";
        string[] lines = File.ReadAllLines(pathWords);
        
        string filteredWordsPath = "./wordlists/wordsn.txt";

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
}

