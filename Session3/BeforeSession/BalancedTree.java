public class Balanced{
    public int isBalanced(TreeNode a) {
        if(a == null)
            return 1;
        int leftDepth = 0;
        int rightDepth = 0;
        if(a.left != null)
            leftDepth = depth(a.left);
        if(a.right != null)
            rightDepth = depth(a.right);
        if(Math.abs(leftDepth - rightDepth) <= 1 && isBalanced(a.left) == 1 && isBalanced(a.right) == 1)
            return 1;
        return 0;
        
    }
    public int depth(TreeNode a){
        if(a == null)
            return 0;
        return 1 + Math.max(depth(a.left), depth(a.right));
    }
    public static void main(String[] args){
    }
}
