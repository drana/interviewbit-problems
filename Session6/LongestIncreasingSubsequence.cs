class Solution {
    public int lis(List<int> A) {
        int n = A.Count();
        int[] lis = new int[n]; // intialize array for lis
        int max =0;
        
        for(int i = 0; i<n ; i++){
            lis[i] =1;//since each indiviual sequence has length 1
        }
        
        for(int i=1;i<n;i++){
            for(int j=0;j<i;j++){
                if(A[i] > A[j] && lis[i]<(lis[j]+1)){
                    lis[i] = lis[j] + 1;
                }
            }
        }
        
        for(int i =0;i<n;i++){
            if(max<lis[i]){
                max = lis[i];
            }
        }
        
        return max;
        
        
        
        
    }
}

   
