namespace MostWater.Test;

[TestFixture]
public class SolutionTest
{

    [Test]
    public void MaxArea_WithSampleInput_Returns49()
    {
        // arrange
        var input = new [] {1,8,6,2,5,4,8,3,7};
        
        // act
        var result = Solution.MaxArea(input);

        Assert.That(result, Is.EqualTo(49));
    }

    [Test]
    public void MaxArea_WithTrivialInput_Returns1()
    {
        // arrange
        var input = new [] {1,1};
        
        // act
        var result = Solution.MaxArea(input);

        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void MaxArea_WithInputOfOne_Returns0()
    {
        // arrange
        var input = new [] {1};
        
        // act
        var result = Solution.MaxArea(input);

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void MaxArea_WithEmptyInput_Returns0()
    {
        // arrange
        var input = new int[] {};
        
        // act
        var result = Solution.MaxArea(input);

        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void MaxArea_WithNullInput_Returns0()
    {
        // arrange
        int[] input = null;
        
        // act
        var result = Solution.MaxArea(input);

        Assert.That(result, Is.EqualTo(0));
    }
}