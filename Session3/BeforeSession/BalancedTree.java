/**
 * Definition for binary tree
 * class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
	public int isBalanced(TreeNode a) {
	    
	    if(a == null)
            return 1;
        int leftHeight = 0;
        int rightHeight = 0;
        if(a.left != null)
            leftHeight = Height(a.left);
        if(a.right != null)
            rightHeight = Height(a.right);
        if(Math.abs(leftHeight - rightHeight) <= 1 && isBalanced(a.left) == 1 && isBalanced(a.right) == 1)
            return 1;
        return 0;
        
	}
	
	public int Height(TreeNode A){
        if(A == null)
            return 0;
        return 1 + Math.max(Height(A.left), Height(A.right));
    }
}
