/**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
class Solution {
    public int isSameTree(TreeNode A, TreeNode B) {
        
        if(A==null && B==null)
            return 1;
        else if(A==null || B== null)
            return 0;
            
        if(A.val == B.val && isSameTree(A.left,B.left) ==1 && isSameTree(A.right,B.right)==1)
            return 1;
            
        return 0;    
    }
}
