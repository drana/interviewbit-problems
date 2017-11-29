class Solution {
    public List<int> maxset(List<int> A) {
                    int start = 0;
            long end = 0;
            long andStart = 0;
            long sumTillNow = Int32.MinValue;
            long maxTillNow = Int32.MinValue;
                int i = 0;
            long length = 0;
            int ansStart = 0;
            long ansLength = 0;
            long ansEnd = -1;
        List<int> result = new List<int>();

            while (i < A.Count())
            {
                if (A[i] >= 0)
                {
                    start = i;
                    sumTillNow = 0;
                    length = 0;

                    while (i < A.Count() && A[i] >=0)
                    {
                        sumTillNow += A[i];
                        i++;
                    }
                    end = i - 1;
                    if ((sumTillNow > maxTillNow) || (sumTillNow == maxTillNow && end - start + 1 < ansLength))
                    {
                        ansStart = start;
                        ansEnd = end;
                        ansLength = start + end - 1;
                        maxTillNow = sumTillNow;
                    }
                }
                i++;
            }

            for (int k =(ansStart); k <= ansEnd; k++)
            {
                result.Add(A[k]);
            }
            return result;
    }
}
