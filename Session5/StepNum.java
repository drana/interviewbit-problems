public class Solution {
    public ArrayList<Integer> stepnum(int a, int b) {
                ArrayList<Integer> result = new ArrayList<Integer>();
        Queue<Integer> queue = new LinkedList<Integer>();
        int i = 0;
        int temp =0;
        if(a == 0)
        result.add(a);
        for(int j = 1; j < 10; j++){
            queue.offer(j);
        }
        temp = queue.poll();
        while(temp <= b){
            
            if(a <= temp && temp <= b){
                result.add(temp);
            }
            
            int lastDigit = temp % 10;
            if(lastDigit == 0)
                queue.offer(temp * 10 + 1);
            else if(lastDigit == 9)
                queue.offer(temp * 10 + 8);
            else{
                queue.offer(temp * 10 + lastDigit - 1);
                queue.offer(temp * 10 + lastDigit + 1);
            }
            //System.out.println(" Queue: " + queue);

            temp = queue.poll();
        }
        return result;
    }
    
    public static ArrayList<Integer> steppingNo(int s, int e) {
        ArrayList<Integer> res = new ArrayList<Integer>();
        int i = 0;
        while (s <= e) {
            if (isStepping(s)) {
                res.add(s);
            }
            s++;
        }
        return res;
    }
    
    private static boolean isStepping(int i) {
        if (i >= 0 && i <= 9) return true;
        while (i >= 10) {
            if (Math.abs(i % 10 - (i / 10) % 10) != 1) { // compare last two digits
                return false;
            }
            i = i / 10;
        }
        return true;
    }
}
