using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class PrimeNumberSetBitsBinaryRepresentation
    {
        public static int CountPrimeSetBits(int left, int right) //What is the Prime Number???????????????
        {

            // tot_bit store number of bit in number
            int tot_bit, count = 0;

            // iterate loop from l to r
            for (int i = left; i <= right; i++)
            {

                // use predefined function for finding
                // set bit it is return number of set bit
                tot_bit = BitCount(i);

                // check tot_bit prime or, not
                if (isPrime(tot_bit))
                    count++;
            }
            return count;
        }

        static bool isPrime(int n)
        {
            // Corner cases
            if (n <= 1) return false;
            if (n <= 3) return true;

            // This is checked so that we can skip
            // middle five numbers in below loop
            if (n % 2 == 0 || n % 3 == 0) return false;

            for (int i = 5; i * i <= n; i = i + 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;

            return true;
        }

        static int BitCount(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n &= (n - 1);
            }

            return count;
        }
    }
}
