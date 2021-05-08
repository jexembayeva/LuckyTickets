using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckyTicketsBase
{
    public class LuckyTicketsDynamicTask : ITask
    {
        public string Run(string[] data)
        {
            var n = Convert.ToInt32(data[0]);
            var digits = Enumerable.Repeat<decimal>(1, 10).ToList().Concat(new decimal[n * 9 - 9].ToList());

            foreach (var range in new decimal[n - 1])
            {
                var list = new List<decimal>();
                for (int x = 1; x < digits.Count() + 1; x++)
                {
                    if (x < 10)
                    {
                        list.Add(digits.ToList().GetRange(0, x).Sum());
                    }
                    else
                    {
                        list.Add(digits.Reverse().Skip(digits.Count() - x).ToList().GetRange(0, 10).Sum());
                    }
                }
                digits = list;
            }
            return checked(digits.Sum(x => x*x)).ToString();
        }       
    }
}
