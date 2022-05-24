using NUnit.Framework;
using System;

namespace Solution 
{
  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SimpleTests()
    {
      Assert.AreEqual(0, Kata.ShortestStepsToNum(1));
      Assert.AreEqual(4, Kata.ShortestStepsToNum(12));
      Assert.AreEqual(4, Kata.ShortestStepsToNum(16));
      Assert.AreEqual(9, Kata.ShortestStepsToNum(71));
    }
  }
}