using System.Collections.Generic;

namespace ProjectEulerCSharp
{
    public static class Problem50
    {
        public static int FindLongestSumOfConsecutivePrimes(int limit, int[] primes)
        {
            var primesSet = new HashSet<int>(primes);
            int maxCount = 0;
            int maxPrime = 0;
            int sum = 0;
            int end = 0;
            int start = 0;
            while (start < primes.Length)
            {
                while (end < primes.Length && sum + primes[end] < limit)
                {
                    sum += primes[end];
                    ++end;
                }

                while (end - start > maxCount && !primesSet.Contains(sum))
                {
                    --end;
                    sum -= primes[end];
                }    

                if (end - start > maxCount)
                {
                    maxCount = end - start;
                    maxPrime = sum;
                }

                sum -= primes[start++];
            }

            return maxPrime;
        }
    }
}
