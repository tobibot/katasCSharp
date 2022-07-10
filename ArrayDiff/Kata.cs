using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    if (a.Length == 0)
        return a;
    var c = b.ToList();
    var deleteFlags = new bool[a.Length];

    for(var i = 0; i < a.Length; i++) 
    {
        if (c.Contains(a[i]))        
            deleteFlags[i] = true;           
        
    }

    var result = new int[a.Length - deleteFlags.Count(d => d)];
    var ctr = 0;
    for (var j =  0; j < a.Length; j++)
    {
        if (!deleteFlags[j])
        {
            result[ctr++] = a[j];
        }
    }
    return result;
  }
}