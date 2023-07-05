using NUnit.Framework;
using System;
public class ExampleTests
{
    [Test]
    public void TestUp()
    {
        int[][] queues =
        {
            new int[0], // G
            new int[0], // 1
            new int[]{5,5,5}, // 2
            new int[0], // 3
            new int[0], // 4
            new int[0], // 5
            new int[0], // 6
        };
        var result = Dinglemouse.TheLift(queues, 5);
        Assert.AreEqual(new[] { 0, 2, 5, 0 }, result);
    }

    [Test]
    public void TestDown()
    {
        int[][] queues =
        {
            new int[0], // G
            new int[0], // 1
            new int[]{1,1}, // 2
            new int[0], // 3
            new int[0], // 4
            new int[0], // 5
            new int[0], // 6
        };
        var result = Dinglemouse.TheLift(queues, 5);
        Assert.AreEqual(new[] { 0, 2, 1, 0 }, result);
    }

    [Test]
    public void TestUpAndUp()
    {
        int[][] queues =
        {
            new int[0], // G
            new int[]{3}, // 1
            new int[]{4}, // 2
            new int[0], // 3
            new int[]{5}, // 4
            new int[0], // 5
            new int[0], // 6
        };
        var result = Dinglemouse.TheLift(queues, 5);
        Assert.AreEqual(new[] { 0, 1, 2, 3, 4, 5, 0 }, result);
    }

    [Test]
    public void TestDownAndDown()
    {
        int[][] queues =
        {
            new int[0], // G
            new int[]{0}, // 1
            new int[0], // 2
            new int[0], // 3
            new int[]{2}, // 4
            new int[]{3}, // 5
            new int[0], // 6
        };
        var result = Dinglemouse.TheLift(queues, 5);
        Assert.AreEqual(new[] { 0, 5, 4, 3, 2, 1, 0 }, result);
    }

    [Test]
    public void IsWholeQueueEmpty_QueueEmpty_ReturnsTrue()
    {
        int[][] queues =
        {
            new int[0], // G
            new int[0], // 1
            new int[0], // 2
            new int[0]  // 3
        };
        var result = Dinglemouse.IsWholeQueueEmpty(queues);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsWholeQueueEmpty_QueueNulls_ReturnsTrue()
    {
        int[][] queues =
        {
            null, // G
            null, // 1
            null, // 2
        };
        var result = Dinglemouse.IsWholeQueueEmpty(queues);
        Assert.That(result, Is.True);
    }

    [Test]
    public void TestLetOnePersonIn_OneSuitableCandidateAndEnoughCapacity_OnePersonIsLetIn()
    {
        Dinglemouse.currentFloor = 0;
        Dinglemouse.currentDirection = Dinglemouse.up;
        var floorQueue = new List<int>{5, 3, 9};
        var elevator = new List<int>{8, 4, 3};

        Dinglemouse.letOnePersonIn(floorQueue, elevator);

        Assert.That(elevator, Does.Contain(5));
        Assert.That(floorQueue, Does.Not.Contain(5));
        Assert.That(elevator.Count, Is.EqualTo(4));
        Assert.That(floorQueue.Count, Is.EqualTo(2));
    }

    [Test]
    public void IsNobodyWaitingInDirection_NobodyTher_ReturnsTrue()
    {

    }
}