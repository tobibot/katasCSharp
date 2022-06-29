namespace Solution 
{
  using NUnit.Framework;
  using System;  

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void BasicTests()
    {
      var
      expected = new int[][] { new int[] { 1, 2, 3} };
      Assert.AreEqual(expected, Kata.GroupIn10s(new int[] { 1, 2, 3 }));
      
      expected = new int[][] { new int[] { 3, 8 }, 
                               new int[] { 12, 17, 19 },
                               new int[] { 25 },
                               new int[] { 35, 38 },
                               null,
                               new int[] { 50 } };
      Assert.AreEqual(expected, Kata.GroupIn10s(new int[] { 8, 12, 38, 3, 17, 19, 25, 35, 50 }));
      
      expected = new int[][] { null,
                               new int[] { 10, 11, 12, 13 },
                               new int[] { 25, 28, 29 }, 
                               null,
                               new int[] { 49 },
                               new int[] { 51 },
                               null,
                               null,
                               null,
                               new int[] { 90 } };
      Assert.AreEqual(expected, Kata.GroupIn10s(new int[] { 12, 10, 11, 13, 25, 28, 29, 49, 51, 90 }));
      
      Assert.AreEqual(new int[][] { }, Kata.GroupIn10s(new int[] { }));

      expected = new int[][] { null,
                               null,
                               null,
                               null,
                               null,
                               null,
                               null,
                               null,
                               null,
                               null,
                               new int[] { 100 } };
      
      Assert.AreEqual(expected, Kata.GroupIn10s(new int[] { 100 }));
    }
  }
}