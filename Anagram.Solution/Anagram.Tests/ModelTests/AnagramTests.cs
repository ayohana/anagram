using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class WordsTests
  {

    [TestMethod]
    public void WordsConstructor_CreatesInstanceOfWords_Words()
    { 
      Words testWords = new Words();
      Assert.AreEqual(typeof(Words), testWords.GetType());
    }

    [TestMethod]
    public void GetFirstWord_ReturnsFirstWord_String()
    {
      string firstTestWord = "bread"; 
      Words testWords = new Words();
      testWords.AddWord(firstTestWord);

      Assert.AreEqual(firstTestWord, testWords.ListOfWords[0]);
    }

    [TestMethod]
    public void GetListOfWords_ReturnsListOfWords_ListOfStrings()
    {
      string testMultipleWords = "bread beard";
      Words testWords = new Words();
      testWords.SplitWords(testMultipleWords);

      List<string> expected = new List<string> { "bread", "beard" };
      List<string> testResult = testWords.ListOfWords;

      CollectionAssert.AreEqual(expected, testResult);
    }
  }
}