using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumToWordTests
  {
    [TestMethod]
    public void NumberToChunks_ReturnsIntArrayOf3DigitChunks_IntArray()
    {
      int test = 123456789;
      int[] expectedResult = new int[] {123, 456, 789};

      int[] actualResult = NumToWord.NumberToChunks(test);

      CollectionAssert.AreEqual(expectedResult, actualResult);
    }
    [TestMethod]
    public void NumberToChunks_IntArrayIndexZeroProperSizeForAnyInputLength_IntArray()
    {
      int testOne = 1234567;
      int testTwo = 12345678;
      int[] expectedResultOne = new int[] {1, 234, 567};
      int[] expectedResultTwo = new int[] {12, 345, 678};

      int[] actualResultOne = NumToWord.NumberToChunks(testOne);
      int[] actualResultTwo = NumToWord.NumberToChunks(testTwo);

      CollectionAssert.AreEqual(expectedResultOne, actualResultOne);
      CollectionAssert.AreEqual(expectedResultTwo, actualResultTwo);
    }

    [TestMethod]
    public void ChunkToWord_ReturnsWordEquivalentOfNumber_String()
    {
      string testZero = "";
      string testOne = "five";
      string testTwo = "fifteen";
      string testThree = "twenty seven";
      string testFour = "five hundred one";
      string testFive = "six hundred thirty four";
      string testSix = "six hundred nineteen";

      string resultZero = NumToWord.ChunkToWord(0);
      string resultOne = NumToWord.ChunkToWord(5);
      string resultTwo = NumToWord.ChunkToWord(15);
      string resultThree = NumToWord.ChunkToWord(27);
      string resultFour = NumToWord.ChunkToWord(501);
      string resultFive = NumToWord.ChunkToWord(634);
      string resultSix = NumToWord.ChunkToWord(619);

      Assert.AreEqual(testZero, resultZero);
      Assert.AreEqual(testOne, resultOne);
      Assert.AreEqual(testTwo, resultTwo);
      Assert.AreEqual(testThree, resultThree);
      Assert.AreEqual(testFour, resultFour);
      Assert.AreEqual(testFive, resultFive);
      Assert.AreEqual(testSix, resultSix);
    }
  }
}