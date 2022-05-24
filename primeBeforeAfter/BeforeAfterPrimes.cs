namespace primeBeforeAfter;

public class BeforeAfterPrimes
{            
    public static long[] PrimeBefAft(long num)
    {
        static bool isPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (long)System.Math.Floor(System.Math.Sqrt(number));

            for (long i = 3; i <= boundary; i+=2)
                if (number % i == 0)
                    return false;

            return true;        
        }

        long afterOfBefore(long toCheck, int direction) {            
            while (true)
            {
                toCheck += direction;
                if (isPrime(toCheck))
                    break;
            }
            return toCheck;
        }      

        long pBefore = afterOfBefore(num, -1);
        long pAfter = afterOfBefore(num, +1);
    
        return new long[]{pBefore, pAfter};
    }

    
    
}
