using System;
using System.Collections.Generic;
using System.Linq;

namespace _02PrintTree
{
    class PrintTree
    {
        private static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();

        static void Main(string[] args)
        {
            ReadTree();
            PrintNode(GetRootNode());
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
    }
}
