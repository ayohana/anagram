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
      Words testWords = new Words();
      Assert.AreEqual(typeof(Words), testWords.GetType());
    }
  }
}