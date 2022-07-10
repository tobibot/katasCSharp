using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    var a = 'a';
    var A = 'A';
    var areLettersHit = new bool[26];

    foreach (var c in str) 
    {
        if (c - a >= 0 && c - a < 26)
            areLettersHit[c - a] = true;
      
        if (c - A >= 0 && c - A < 26)
            areLettersHit[c - A] = true;

        if (areLettersHit.All(a => a))
            return true;
    }
    return false;
  }
}