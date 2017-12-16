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
	public TreeNode sortedArrayToBST(final List<Integer> a) {
	    if(a==null || a.size()==0)
	        return null;
	   
	   TreeNode result = convertArrayToBST(a, 0, a.size()-1);
	   
	   return result;
	        
	}
	
	public TreeNode convertArrayToBST(final List<Integer> a, int start, int end) {
        if(start > end)
            return null;//when we reach end of a path
        int mid = (start + end)/2;// get mid point to be node and left and right to children recuringly
        TreeNode root = new TreeNode(a.get(mid));
        root.left = convertArrayToBST(a, start, mid - 1);
        root.right = convertArrayToBST(a, mid+1, end);
        return root;
    }
}
