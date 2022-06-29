using System.Collections.Generic;
using  System.Linq;

public class Kata
{
  public static int[][] GroupIn10s(int[] array) 
  {   
    var tmpResult = new Dictionary<int, List<int>>();
    
    foreach (var number in array) {
      var idx = number / 10;
      if (!tmpResult.ContainsKey(idx)) 
        tmpResult[idx] = new List<int>();
      tmpResult[idx].Add(number);      
    }

    var max = tmpResult.Keys.Any() ? tmpResult.Keys.Max() : 0;

    for (int i=0; i< max; i++) 
    {
      if (!tmpResult.ContainsKey(i))
        tmpResult[i] = null;
    }  
  
    var finalResult = new int[tmpResult.Keys.Count][];

    foreach (var key in tmpResult.Keys) 
    {
      if (tmpResult[key] != null)
        finalResult[key] = tmpResult[key].OrderBy(l => l).ToArray();
    }

    return finalResult;
  }
}