using System;
using System.Numerics;

namespace LeetCode263
{
    public class Solution
    {
        public bool IsUgly(int n)
        {
            return n <= 0 ? false : (BigInteger.Pow(30, 32) % n) == 0;
        }
    }
    /*public class Solution
    {
        public bool IsUgly(int n)
        {
            if (n <= 0) return false;
            if (n == 1) return true;
            if (n % 2 == 0) return IsUgly(n / 2);
            if (n % 3 == 0) return IsUgly(n / 3);
            if (n % 5 == 0) return IsUgly(n / 5);
            return n == 1;
        }
    }*/
}
