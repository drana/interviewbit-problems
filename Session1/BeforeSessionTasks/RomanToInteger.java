public class Solution {
     public static int c2n(char c){
        switch(c) {
            case 'I' : return 1;
            case 'V' : return 5;
            case 'X' : return 10;
            case 'L' : return 50;
            case 'C' : return 100;
            case 'D' : return 500;
            case 'M' : return 1000;
            default : return 0;            
        }
    }
     public static int romanToInt(String a) {
        int result = 0;
        for(int i = 0; i < a.length(); i++){
            if(i > 0  && c2n(a.charAt(i)) > c2n(a.charAt(i-1))){
                result += c2n(a.charAt(i)) - 2 * c2n(a.charAt(i-1));
            }
            else{
                result += c2n(a.charAt(i));
            }
        }
        return result;        
    }
    public static void main(String[] args){
        String a = args[0];
        System.out.println(romanToInt(a));
    }

}
