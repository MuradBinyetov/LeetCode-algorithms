using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class BinaryTreeInorderTraversal
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            var res = new List<int>();
            while (root != null)
            {
                if (root.left == null)
                {
                    res.Add(root.val);
                    root = root.right;
                }
                else
                {
                    var pre = root.left;
                    while (pre.right != null && pre.right != root)
                    {
                        pre = pre.right;
                    }

                    if (pre.right == null)
                    {
                        pre.right = root;
                        root = root.left;
                    }
                    else
                    {
                        pre.right = null;
                        res.Add(root.val);
                        root = root.right;
                    }
                }

            }

            return res;
        }
    }

    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
      {
            this.val = val;
            this.left = left;
            this.right = right;
      }
    }
}
