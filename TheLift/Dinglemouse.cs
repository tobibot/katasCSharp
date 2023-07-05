using System;
public class Dinglemouse
{
    internal const int up = +1;
    internal const int down = -1;
    internal static int currentDirection = up;
    internal static int currentFloor = 0;
    internal static List<int> elevator;
    internal static int elevatorCapacity;
    internal List<int> visitedFloors = new List<int>();

    public static int[] TheLift(int[][] queues, int capacity)
    {
        elevatorCapacity = capacity;
        elevator = new List<int>();
        var maxFloor = queues.Length;

        while (!IsWholeQueueEmpty(queues))
        {
            var floorQueue = queues[currentFloor].ToList();
            inspectFloorQueue(floorQueue);
            if (IsWholeQueueEmpty(queues))
                {
                    currentFloor = 0;
                    break;
                }

            if (currentFloor == 0)            
                currentDirection = up;            
            else if (currentFloor == maxFloor)            
                currentDirection = down;
            else
            {
                if (isNobodyWaitingInDirection(queues, currentDirection))
                {
                    currentDirection *= -1;
                }
            }
            currentFloor += currentDirection;            
        }
        
        return new int[0];
    }

    private static bool isNobodyWaitingInDirection(int[][] queues, int currentDirection)
    {
        throw new NotImplementedException();
    }

    private static void inspectFloorQueue(List<int> floorQueue)
    {
        if (floorQueue == null || floorQueue.Count == 0)
            return;

        // exit
        elevator.Where(e => e == currentFloor).ToList().All(e => elevator.Remove(e));

        // check if all people exited
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
        
    }

    internal static void letOnePersonIn(List<int> floorQueue, List<int> elevator)
    {   
        for (var i = 0; i < floorQueue.Count; i++)
        {
            if (floorQueue[i] > currentFloor)
            {
                elevator.Add(floorQueue[i]);
                floorQueue.RemoveAt(i);
                return;                
            }
        }
    }

    internal static void letOnePersonLeave(List<int> floorQueue, List<int> elevator)
    {
        
    }

    internal static bool IsWholeQueueEmpty(int[][] queues) =>
        queues.All(q => q == null || q.Length == 0);
    
    
    
}
