using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class WordsTests
  {

    [TestMethod]
    public void WordsConstructor_CreatesInstanceOfWords_Words()
    { 
      Words actual = new Words();
      Assert.AreEqual(typeof(Words), actual.GetType());
    }

    [TestMethod]
    public void GatherSingleWord_ReturnsSingleWordInArray_StringArray()
    {
      Words actual = new Words();
      string expected = "bread";
      actual.ConvertToArray(expected);
      Assert.AreEqual(expected, actual.wordsArr[0]);
    }

    [TestMethod]
    public void GatherMultipleWords_ReturnsMultipleWordsInArray_StringArray()
    {
      Words actual = new Words();
      string testWords = "bread beard";
      actual.ConvertToArray(testWords);
      string[] expected = new string[] { "bread", "beard" };
      CollectionAssert.AreEqual(expected, actual.wordsArr);
    }

  }
}