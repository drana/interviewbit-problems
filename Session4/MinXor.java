public class Solution {
    public int findMinXor(ArrayList<Integer> A) {
        

        int n = A.size();
        Collections.sort(A);
        
        int minXor = Integer.MAX_VALUE;
        int val = 0;
       
         // calculate min xor of consecutive pairs
        for(int i=0;i<n-1;i++)
        {
            val = A.get(i)^A.get(i+1);
            minXor = Math.min(minXor, val);
        }
          
        return minXor;
        
    }
    
   
}
