using NUnit.Framework;
using System;
public class MysteryFunctionTest
{
    [Test]
    public void MysteryTest()
    {
        Assert.AreEqual(5, MysteryFunction.Mystery(6), "mystery(6) ");
        Assert.AreEqual(13, MysteryFunction.Mystery(9), "mystery(9) ");
        Assert.AreEqual(26, MysteryFunction.Mystery(19), "mystery(19) ");
    }

    [Test]
    public void MysteryInvTest()
    {
        Assert.AreEqual(6, MysteryFunction.MysteryInv(5), "mysteryInv(5)");
        Assert.AreEqual(9, MysteryFunction.MysteryInv(13), "mysteryInv(13)");
        Assert.AreEqual(19, MysteryFunction.MysteryInv(26), "mysteryInv(26)");
    }
}