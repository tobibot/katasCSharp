using System;

namespace Solution
{
  public static class Kata
  {
    public static int ShortestStepsToNum(int num)
    {
      
      	if (num <= 1 || num > 1000000)
        {
		    return 0;
	    }
        if (num%2 == 0) {
            return ShortestStepsToNum(num/2) + 1;
        } else if (num > 1) {
            return ShortestStepsToNum(num-1) + 1;
        } else {
            return 0;
        }

    }
  }
}