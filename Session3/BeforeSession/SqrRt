public class Solution {
	public int sqrt(int A) {
	            long i = 0;
        long j = A / 2 + 1;
        while(i <= j){
            long mid = (i + j) / 2;
            if(mid *  mid == A)
                return (int)mid;
            if(mid *  mid < A)
                i = mid + 1;
            else
                j = mid - 1;
        }
        return (int)j;
	}
}
