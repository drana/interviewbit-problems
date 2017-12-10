public class Solution {
	public int lengthOfLongestSubstring(String a) {
	    int n = a.length();
	    int ans = 0;
	    
        Map<Character, Integer> map = new HashMap<>(); 
        for (int j = 0, i = 0; j < n; j++) {
            if (map.containsKey(a.charAt(j))) {
                i = Math.max(map.get(a.charAt(j)), i);
            }
            ans = Math.max(ans, j - i + 1);
            map.put(a.charAt(j), j + 1);
        }
        return ans;
	}
}
