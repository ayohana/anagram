using System;

namespace Anagram.Models
{
  public class Words
  {
    public string[] wordsArr { get; set; }

    public void ConvertToArray(string input)
    {
      if (CheckForSpaces(input))
      {
        char[] splitters = new char[] { '\r', '\n', ' ', ',', '.', '/' };
        // \r is a line break in Windows
        // \n is a line break in Mac
        // add more special characters here 
        wordsArr = input.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
        // RemoveEmptyEntries is used to avoid empty results. Sometimes Split() can return an array with empty strings in it—this can be unwanted. This can happen when 2 delimiters are adjacent.
        Array.Sort(wordsArr);
      }
      else
      {
        wordsArr = new string[] { input };
      }
    }

    public bool CheckForSpaces(string input)
    {
      return input.Contains(" ");
    }

    public void CheckForAnagrams()
    {
      int i = 1;
      foreach (string word in wordsArr)
      {
        char[] word1 = word.ToCharArray();
        char[] word2 = wordsArr[i].ToCharArray();
        Array.Sort(word1);
        Array.Sort(word2);
        string joined1 = string.Join("", word1);
        string joined2 = string.Join("", word2);
        // Activate debuggers below to see which words are being compared by the application:
        // Console.WriteLine("joined1 = " + joined1);
        // Console.WriteLine("joined2 = " + joined2);
        
        // Compare Two Strings Case-Insensitively
        if (string.Equals(joined1, joined2, StringComparison.OrdinalIgnoreCase))
        {
          Console.WriteLine($"{word} and {wordsArr[i]} are anagrams.");
        }

        if (i == wordsArr.Length-1)
        {
          i = 0;
        }
        else
        {
          i++;
        }
      }
    }
    
  }
}