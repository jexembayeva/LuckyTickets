using System;

namespace LuckyTicketsBase
{
    public class LuckyTicketsRecursionTask : ITask
    {
        int n; int q;
        public string Run(string[] data)
        {
            n = Convert.ToInt32(data[0]);
            q = 0;

            NextDigit(0, 0, 0);
            return q.ToString();
        }

        private void NextDigit(int digit, int sum1, int sum2)
        {
            if (digit == n)
            {
                if (sum1 == sum2)
                    q++;
                return;
            }
            for (int a1 = 0; a1 <= 9; a1++)
                for (int b1 = 0; b1 <= 9; b1++)
                    NextDigit(digit + 1, sum1 + a1, sum2 + b1);

        }
    }
}
