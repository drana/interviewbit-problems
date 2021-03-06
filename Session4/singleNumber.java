public class Solution {
    // DO NOT MODIFY THE LIST. IT IS READ ONLY
    public int singleNumber(final List<Integer> A) {
        int result = A.get(0);
        for(int i = 1; i < A.size(); i++){
            result ^= A.get(i);
        }
        return result;
    }
}
