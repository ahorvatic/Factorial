using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public static class Math
    {
        public static long Factorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; ++i)
                result *= i;

            return result;
        }
    }
}
