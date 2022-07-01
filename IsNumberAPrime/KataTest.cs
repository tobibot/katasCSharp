namespace Solution 
{
  using NUnit.Framework;
  using System;
  using System.Collections.Generic;

  [TestFixture]
  public class SolutionTest
  {
    private static IEnumerable<TestCaseData> sampleTestCases
    {
      get
      {
        yield return new TestCaseData(0).Returns(false);
        yield return new TestCaseData(1).Returns(false);
        yield return new TestCaseData(2).Returns(true);
        yield return new TestCaseData(4).Returns(false);        
        yield return new TestCaseData(21).Returns(false);
        yield return new TestCaseData(97).Returns(true);
        yield return new TestCaseData(5099).Returns(true);
      }
    }
  
    [Test, TestCaseSource("sampleTestCases")]
    public bool SampleTest(int n) => Kata.IsPrime(n);


    // [Test]
    // public void TestData()
    // { 
    //   // Assert.That(Kata.IsPrime(97));

    // }
  }


}