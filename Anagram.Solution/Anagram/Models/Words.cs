using System.Collections.Generic;

namespace Anagram.Models
{
  public class Words
  {
    public List<string> ListOfWords { get; set; }

    public Words()
    {
      ListOfWords = new List<string> ();
    }

    public void AddWord(string inputWord)
    {
      ListOfWords.Add(inputWord);
    }

    public void SplitWords(string inputWord)
    {

    }
    
  }
}