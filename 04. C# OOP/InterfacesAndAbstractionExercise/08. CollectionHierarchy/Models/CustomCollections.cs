using _08._CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08._CollectionHierarchy.Models
{
    public abstract class CustomCollections : IAdd
    {
        private ICollection<string> collection;

        public CustomCollections()
        {
            this.collection = new List<string>();
        }

        protected IList<string> Collection
        {
            get
            {
                return (IList<string>)this.collection;
            }
        }

        public abstract int Add(string element);
    }
}
