using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vertical_Order_Traversal_of_a_Binary_Tree
{
    /// <summary>
    /// Given the root of a binary tree, calculate the vertical order traversal of the binary tree.
    /// For each node at position(x, y), its left and right children will be at positions(x - 1, y - 1) and(x + 1, y - 1) respectively.
    /// The vertical order traversal of a binary tree is a list of non-empty reports for each unique x-coordinate from left to right.Each report is a list of all nodes at a given x-coordinate.The report should be primarily sorted by y-coordinate from highest y-coordinate to lowest.If any two nodes have the same y-coordinate in the report, the node with the smaller value should appear earlier.
    /// Return the vertical order traversal of the binary tree.
    /// </summary>
    public class Solution
    {
        private Dictionary<int, List<Tuple<int, int>>> columnTable = new Dictionary<int, List<Tuple<int, int>>>();
        int minColumn = 0, maxColumn = 0;

        private void DFS(TreeNode node, int row, int col)
        {
            if (node == null)
                return;

            if (!columnTable.ContainsKey(col))
            {
                this.columnTable.Add(col, new List<Tuple<int, int>>());
            }

            columnTable[col].Add(new Tuple<int, int>(row, node.val));
            minColumn = Math.Min(minColumn, col);
            maxColumn = Math.Max(maxColumn, col);
            // preorder DFS traversal
            this.DFS(node.left, row + 1, col - 1);
            this.DFS(node.right, row + 1, col + 1);
        }

        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            var output = new List<List<int>>();
            if (root == null)
            {
                return (IList<IList<int>>) output;
            }

            // step 1). DFS traversal
            this.DFS(root, 0, 0);

            // step 2). retrieve the value from the columnTable
            for (int i = minColumn; i < maxColumn + 1; ++i)
            {
                // order by both "row" and "value"
                Dictionary .sort(columnTable.get(i), new Comparator<Pair<Integer, Integer>>() {
                @Override
                public int compare(Pair<Integer, Integer> p1, Pair<Integer, Integer> p2)
                {
                    if (p1.getKey().equals(p2.getKey()))
                        return p1.getValue() - p2.getValue();
                    else
                        return p1.getKey() - p2.getKey();
                }
            });

            List<Integer> sortedColumn = new ArrayList();
            for (Pair<Integer, Integer> p : columnTable.get(i))
            {
                sortedColumn.add(p.getValue());
            }
            output.add(sortedColumn);
        }

        return (IList<IList<int>>) output;
    }


    }
}
