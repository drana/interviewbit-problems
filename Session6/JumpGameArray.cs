class Solution {
    public int canJump(List<int> A) {
        int next = A.Count() - 1;
        
        for(int i = A.Count() - 2; i >= 0; i--){
            if(A[i] >= next - i)
                next = i;            
        }
        return next == 0 ? 1 : 0;
    }
}
