using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class MonotonicArray
    {
        public static bool IsMonotonic(int[] nums)
        {
            return Increasing(nums) || Decreasing(nums);
        }

        public static bool Increasing(int[] A)
        {
            for (int i = 0; i < A.Length - 1; ++i)
                if (A[i] > A[i + 1]) return false;
            return true;
        }

        public static bool Decreasing(int[] A)
        {
            for (int i = 0; i < A.Length - 1; ++i)
                if (A[i] < A[i + 1]) return false;
            return true;
        }
    }
}
