class Solution {
    public int longestSubsequenceLength(List<int> A) {
        
        int n = A.Count();
        if(n == 0)
            return 0;
        
        int[] lis = new int[n]; // intialize array for lis
        int[]lds = new int[n];
        
        
        for(int i = 0; i<n ; i++){
            lis[i] =1;//since each indiviual sequence has length 1
        }

        for(int i = 0; i<n ; i++){
            lds[i] =1;//since each indiviual sequence has length 1
        }
        
        // lis 
        for(int i=1;i<n;i++){
            for(int j=0;j<i;j++){
                if(A[i] > A[j] && lis[i]<(lis[j]+1)){
                    lis[i] = lis[j] + 1;
                }
            }
        }
        
        // lds 
        for(int i=n-2;i>=0;i--){
            for(int j=n-1;j>i;j--){
                if(A[i] > A[j] && lds[i]<(lds[j]+1)){
                    lds[i] = lds[j] + 1;
                }
            }
        }
        
        //Compute max value
        int max = lis[0] + lds[0] -1;
        
        for(int i =1;i<n;i++){
            if((lis[i] + lds[i] -1) > max){
                max = lis[i]  + lds[i] - 1;
            }
        }
        
        return max;
        
        
    }
}
