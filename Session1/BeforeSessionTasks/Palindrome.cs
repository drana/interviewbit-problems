public class Solution {
	public int isPalindrome(String a) {
	    
	    a = a.replaceAll("[^a-zA-Z0-9]", "");
	    a= a.toLowerCase();
	    boolean result = isPal(a);
	    if (result){
	        return 1;
	    }
	    else{
	        return 0;
	    }
	}
	
	static boolean isPal(String original){
	   int i = original.length()-1;
        int j=0;
        while(i > j) {
            if(original.charAt(i) != original.charAt(j)) {
                return false;
            }
            i--;
            j++;
        }
        return true;   
        
        
	}
	
	
	
}
