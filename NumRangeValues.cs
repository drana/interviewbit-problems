using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class NumRange
    {
        public int NumRangeValues(List<int>A, int B, int C)
        {
            //A: [10, 5, 1, 0, 2]  (B, C) : (6, 8)

            A = new List<int> { 76, 22, 81, 77, 95, 23, 27, 35, 24, 38, 15, 90, 19, 46, 53, 6, 77, 96, 100, 85, 43, 16, 73, 18, 7, 66 };
            List<List<int>> result = new List<List<int>>();

            int lo = 98;
            int hi = 290;


            int count = 0;
            if (A.Count() == 0)
            {

            }
            for (int i = 0; i < A.Count(); i++)
            {
                int sum = 0;
                for (int j = i; j < A.Count(); j++)
                {
                    sum = sum + A[j];
                    if (sum >= lo && sum <= hi)
                    {
                        count++;
                    }
                    if (sum > hi)
                    {
                        break;
                    }
                }
            }

            return count;
        }
    }
}
