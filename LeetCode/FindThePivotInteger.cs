using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindThePivotInteger
    {
        public int PivotInteger(int n)
        {
            int sum = (n * (n + 1)) / 2;
            int pivot = (int)Math.Sqrt(sum);

            if (pivot * pivot == sum)
            {
                return pivot;
            }
            return -1;
        }
    }
}
