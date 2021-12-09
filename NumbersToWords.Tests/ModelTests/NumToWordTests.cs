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
  }
}