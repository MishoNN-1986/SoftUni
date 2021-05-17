using System;
using System.Collections.Generic;
using System.Text;

namespace _08AllSubtreesWithAGivenSum
{
    public class Tree<T>
    {
        private T value;
        private Tree<T> parent;
        private List<Tree<T>> children;

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();
            foreach (var child in children)
            {
                this.Children.Add(child);
                child.Parent = this;
            }
        }

        public T Value { get; set; }
        public Tree<T> Parent { get; set; }
        public List<Tree<T>> Children { get; private set; }
    }
}
