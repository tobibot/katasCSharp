namespace primeBeforeAfter;

using System;
using NUnit.Framework;

[TestFixture]
public static class BeforeAfterPrimesTests {

    [Test]
    public static void test1() {
        Assert.AreEqual(new int[] {89, 101}, BeforeAfterPrimes.PrimeBefAft(97));
        Assert.AreEqual(new int[] {97, 101}, BeforeAfterPrimes.PrimeBefAft(100));
        Assert.AreEqual(new int[] {97, 103}, BeforeAfterPrimes.PrimeBefAft(101));
    }
}
