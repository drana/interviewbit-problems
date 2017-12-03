class Solution {
    public int solve(List<int> A) {
        int count = 0;
            for (int i = 0; i < A.Count(); i++)
            {
                count = 0;
                for(int j = 0; j < A.Count(); j++)
                {
                    if (A[j] > A[i])
                        count++;
                }

                if (count == A[i])
                    return 1;
                
            }


            return -1;
    }
}
