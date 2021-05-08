namespace LuckyTicketsBase
{
    public class LuckyTicketsBruteForceTask : ITask
    {
        int q;
        public string Run(string[] data)
        {
            q = 0;

            Calculate3();
            return q.ToString();
        }

        private void Calculate3()
        {
            for (int a1 = 0; a1 <= 9; a1++)
                for (int a2 = 0; a2 <= 9; a2++)
                    for (int a3 = 0; a3 <= 9; a3++)
                        for (int a4 = 0; a4 <= 9; a4++)
                        {
                            int sum1 = a1 + a2 + a3 + a4;

                            for (int b1 = 0; b1 <= 9; b1++)
                                for (int b2 = 0; b2 <= 9; b2++)
                                    for (int b3 = 0; b3 <= 9; b3++)
                                    {
                                        int sum2 = b1 + b2 + b3;
                                        if (sum1 - sum2 >= 0 && sum1 - sum2 <= 9)
                                        {
                                            q++;
                                        }
                                    }
                        }
        }
    }
}
