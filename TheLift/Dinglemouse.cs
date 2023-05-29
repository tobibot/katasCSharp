using System;
public class Dinglemouse
{
    const int up = +1;
    const int down = -1;
    static int currentDirection = up;
    static int currentFloor = 0;
    static List<int> elevator;
    static int elevatorCapacity;
    List<int> visitedFloors = new List<int>();

    public static int[] TheLift(int[][] queues, int capacity)
    {
        elevatorCapacity = capacity;
        elevator = new List<int>();

        while (!IsWholeQueueEmpty(queues))
        {
            var floorQueue = queues[currentFloor];
            inspectFloorQueue(floorQueue);
            
        }
        
        for (var i = 0; i < queues.Length; i++)
        {}

        // Your code here
        return new int[0];
    }

    private static void inspectFloorQueue(int[] floorQueue)
    {
        if (floorQueue.Length == 0)
            return;
        // exit
        elevator.Where(e => e == currentFloor).ToList().All(e => elevator.Remove(e));

        var currentCapacity = elevatorCapacity - elevator.Count;
        if (currentCapacity == 0)
            return;

        // enter
        switch (currentDirection)
        {
            case up:   
                while (floorQueue.Any(fq => fq > currentFloor) && currentCapacity > 0)     
                    letOnePersonIn(floorQueue, elevator);                
                break;
            case down:
                while (floorQueue.Any(fq => fq < currentFloor) && currentCapacity > 0)     
                    letOnePersonIn(floorQueue, elevator);  
                break;
            default:
                throw new ArgumentException();
        }
        
        throw new NotImplementedException();
    }

    private static void letOnePersonIn(int[] floorQueue, List<int> elevator)
    {
        throw new NotImplementedException();
    }

    static bool IsWholeQueueEmpty(int[][] queues) =>
        queues.All(q => q == null || q.Length == 0);
    
    
    
}
