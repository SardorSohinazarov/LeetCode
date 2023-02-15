namespace LeetCode.Easy//solved
{
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            return n > 0 && 1162261467 % n == 0;
            //               2147483647
            /*gap shundaki 3ni 19 - darajasi 1162261467 
             * shu songa teng bo'lar ekan va int.MaxValue 
             * dan kattalashib ketmas ekan.
             * shuning uchun buni bo'luvchilarini
             * 3 ni darajasi deya tan olish mumkin.*/
        }
    }
    /*    public class Solution
        {
            public bool IsPowerOfThree(int n)
            {
                if (n == 0) return false;

                while (n % 3 == 0)
                {
                    n /= 3;
                }
                return n == 1;
            }
        }*/
}
