namespace MostWater.Lib;

public class Solution
{
    public static int MaxArea(int[] height) 
    {   
        if (height == null || height.Length == 0)
            return 0;

        var maxArea = 0;
        var leftColumn = 0;
        var rightColumn = height.Length - 1;

        // Male das erste Rechteck von Links nach rechts
        // Male dann das zweite, indem der kleinere Balken durch den nächsten daneben ersetzt wird
        // Male dann das dritte, 
        // ...
        // Bis die Balken sich treffen, oder die höchsten Balken getroffen wurden

        
        var max = height.Max();

        while (leftColumn < rightColumn) {
            
            var heightToCalcWith = height[rightColumn];
            if (height[leftColumn] < height[rightColumn])
                heightToCalcWith = height[leftColumn];

            var currentWidth = rightColumn - leftColumn;
            var currentArea = heightToCalcWith * currentWidth;

            if (currentArea > maxArea)
                maxArea = currentArea;            

            if (height[leftColumn] == max && height[rightColumn] == max)
                return maxArea;

            if (height[leftColumn] < height[rightColumn])             
                leftColumn++;
            else
                rightColumn--;
        }

        return maxArea;         
    }
}
