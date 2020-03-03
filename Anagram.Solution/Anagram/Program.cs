using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram
{
  public class Program
  {
    public static void Main()
    {
      
      Words words = new Words();
      Console.WriteLine("Enter words you want to check for Anagrams:");
      string input = Console.ReadLine();
      words.AddWord(input);

    }
  }
}
