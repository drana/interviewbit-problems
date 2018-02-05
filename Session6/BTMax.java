/**
 * Definition for binary tree
 * class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) {
 *      val = x;
 *      left=null;
 *      right=null;
 *     }
 * }
 */
public class Solution {
    class Res {
        public int val;
    }
    
    int findMaxUtil(TreeNode node, Res res)
    {

        
        if (node == null)
            return 0;
 
        // l and r store maximum path sum going through left and
        // right child of root respectively
        int l = findMaxUtil(node.left, res);
        int r = findMaxUtil(node.right, res);
 
        // Max path for parent call of root. This path must
        // include at-most one child of root
        int max_single = Math.max(Math.max(l, r) + node.val,
                                  node.val);
 
 
        // Max Top represents the sum when the Node under
        // consideration is the root of the maxsum path and no
        // ancestors of root are there in max sum path
        int max_top = Math.max(max_single, l + r + node.val);
 
        // Store the Maximum Result.
        res.val = Math.max(res.val, max_top);
 
        return max_single;
    }

    public int maxPathSum(TreeNode A) {
          // Initialize result
        // int res2 = Integer.MIN_VALUE;
        Res res = new Res();
        res.val = Integer.MIN_VALUE;
 
        // Compute and return result
        findMaxUtil(A, res);
        return res.val;
    }
}
