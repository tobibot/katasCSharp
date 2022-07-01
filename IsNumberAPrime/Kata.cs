namespace Solution;

public static class Kata
{
  public static bool IsPrime(int n)
  {
    if (n<2)
      return false;
    if (n==2 || n==3)
      return true;
    if (n%2 == 0 || n%3 == 0)
      return false;
    var limit = System.Math.Sqrt(n);
    for (var i = 3; i <= limit; i+=2)
    {
      if (n%i == 0) 
        return false;
    }

    return true;
  }
}