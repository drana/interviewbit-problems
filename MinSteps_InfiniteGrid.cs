class Solution {
    public int coverPoints(List<int> A, List<int> B) {
      int result=0;
      for(int i=1;i< A.Count();i++){
          result = result + (Math.Abs(A[i]-A[i-1])< Math.Abs(B[i]-B[i-1])?Math.Abs(B[i]-B[i-1]):Math.Abs(A[i]-A[i-1]));
      }
      
      return result;
    }
}