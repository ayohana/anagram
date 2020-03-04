using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass] // A Class Containing MSTest Unit Tests
  public class WordsTests
  {

    [TestMethod] // A Unit Test
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
      string testWords = "beard bread";
      actual.ConvertToArray(testWords);
      string[] expected = new string[] { "beard", "bread" };
      CollectionAssert.AreEqual(expected, actual.wordsArr);
    }

    [TestInitialize] // Runs Before Each Test (Optional)
    public void SortMultipleWords_ReturnsSortedWordsInArray_StringArray()
    {
      Words actual = new Words();
      string testWords = "bread bun beard";
      actual.ConvertToArray(testWords);
      string[] expected = new string[] { "beard", "bread", "bun" };
      CollectionAssert.AreEqual(expected, actual.wordsArr);
    }

  }
}