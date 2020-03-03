namespace Anagram.Models
{
  public class Words
  {
    public string[] wordsArr { get; set; }

    public void ConvertToArray(string input)
    {
      if (CheckForSpaces(input))
      {
        wordsArr = input.Split(" ");
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
    
  }
}