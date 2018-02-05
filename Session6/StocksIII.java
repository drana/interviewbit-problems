public class Solution {
    // DO NOT MODIFY THE LIST. IT IS READ ONLY
    public int maxProfit(final List<Integer> a) {
         if(a == null || a.size() == 0)
            return 0;
        
        int profit = 0;
        
        int[] left = new int[a.size()];
        int[] right = new int[a.size()];
        
        left[0] = 0;
        int min = a.get(0);
        for(int i = 1; i < a.size(); i++){
            min = Math.min(min, a.get(i));
            left[i] = Math.max(left[i-1], a.get(i) - min);
        }
        
        right[a.size()-1] = 0;
        int max = a.get(a.size()-1);
        for(int i = a.size() - 2; i >= 0; i--){
            max = Math.max(max, a.get(i));
            right[i] = Math.max(right[i+1], max- a.get(i));
        }
        
        for(int i =0; i < a.size(); i++)
            profit = Math.max(profit, left[i] + right[i]);
        return profit;
        
        
    }
}
