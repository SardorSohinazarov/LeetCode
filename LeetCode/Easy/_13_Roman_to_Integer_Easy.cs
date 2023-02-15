namespace LeetCode.Easy//solved
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            string Rim = s;
            int add = 0;
            int son = 0;
            int oldingisi = 0;
            for (int i = 0; i < Rim.Length; i++)
            {
                if (Rim[i] == 'M')
                    add = 1000;
                else if (Rim[i] == 'D')
                    add = 500;
                else if (Rim[i] == 'C')
                    add = 100;
                else if (Rim[i] == 'L')
                    add = 50;
                else if (Rim[i] == 'X')
                    add = 10;
                else if (Rim[i] == 'V')
                    add = 5;
                else if (Rim[i] == 'I')
                    add = 1;

                if (add <= oldingisi)
                    son += add;
                else
                    son = son - 2 * oldingisi + add;

                oldingisi = add;

            }
            return son;
        }
    }
}
