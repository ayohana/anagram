namespace Anagram.Models
{
  public class Words
  {
    public string[] wordsArr { get; set; }

    public void SplitWords(string input)
    {
      wordsArr = input.Split(" ");
    }
    
  }
}