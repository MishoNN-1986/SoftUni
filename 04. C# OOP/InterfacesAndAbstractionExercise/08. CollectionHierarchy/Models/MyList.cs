using _08._CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08._CollectionHierarchy.Models
{
    public class MyList : AddRemoveCollection, IUsed
    {
        public MyList()
            : base()
        {

        }

        public override string Remove()
        {
            string element = this.Collection[0];
            this.Collection.RemoveAt(0);

            return element;
        }

        public int Used
        {
            get
            {
                return this.Collection.Count;
            }
        }
    }
}
