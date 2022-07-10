namespace Solution
{
  using NUnit.Framework;
  using System;
  
  [TestFixture]
  public class Tests 
  {
    [Test]
    public void SampleTests() 
    {
      Assert.That(Kata.IsPangram("The quick brown fox jumps over the lazy dog."));
      Assert.That(Kata.IsPangram("The quick b"), Is.False);
    }
  }
}