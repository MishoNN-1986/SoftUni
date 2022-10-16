using System;
using System.Collections.Generic;
using System.Linq;

namespace _05DeepestNode
{
    class DeepestNode
    {
        private static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();

        static void Main(string[] args)
        {
            ReadTree();
            Console.WriteLine($"Deepest node: {GetDeepestNode().Value}");
        }

        private static Tree<int> GetTreeNodeByValue(int value)
        {
            if (!nodeByValue.ContainsKey(value))
            {
                nodeByValue[value] = new Tree<int>(value);
            }
            return nodeByValue[value];
        }

        public static void AddEdge(int parent, int child)
        {
            Tree<int> parentNode = GetTreeNodeByValue(parent);
            Tree<int> childNode = GetTreeNodeByValue(child);

            parentNode.Children.Add(childNode);
            childNode.Parent = parentNode;
        }

        private static void ReadTree()
        {
            int nodeCount = int.Parse(Console.ReadLine());
            for (int i = 1; i < nodeCount; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');
                AddEdge(int.Parse(edge[0]), int.Parse(edge[1]));
            }
        }

        private static Tree<int> GetRootNode()
        {
            return nodeByValue.Values
                .FirstOrDefault(x => x.Parent == null);
        }

        private static void PrintNode(Tree<int> node, int indent = 0)
        {
            Console.WriteLine(new string(' ', 2 * indent) + node.Value);

            foreach (var child in node.Children)
            {
                PrintNode(child, indent + 1);
            }
        }

        private static Tree<int>[] GetLeafNodes()
        {
            return nodeByValue.Values
                .Where(t => t.Children.Count == 0)
                .ToArray();
        }

        private static Tree<int>[] GetMiddleNodes()
        {
            return nodeByValue.Values
                .Where(t => t.Parent != null && t.Children.Count > 0)
                .ToArray();
        }

        private static Tree<int> GetDeepestNode()
        {
            int biggestDepth = 0;
            Tree<int> deepestNode = null;
            FindDeepestNode(GetRootNode(), 0, ref biggestDepth, ref deepestNode);
            return deepestNode;
        }

        private static void FindDeepestNode(Tree<int> currentNode, int currentDepth, ref int biggestDepth, ref Tree<int> deepestNode)
        {
            if (biggestDepth < currentDepth)
            {
                biggestDepth = currentDepth;
                deepestNode = currentNode;
            }

            foreach (var child in currentNode.Children)
            {
                FindDeepestNode(child, currentDepth + 1, ref biggestDepth, ref deepestNode);
            }
        }
    }
}
