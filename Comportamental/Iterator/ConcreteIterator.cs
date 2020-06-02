using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int Current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return aggregate[Current];
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override bool IsDone()
        {
            return Current >= aggregate.count;
        }

        public override object Next()
        {
            object ret = null;
            if (Current < aggregate.count -1)
            {
                ret = aggregate[++Current];
            }
            return ret;
        }
    }
}
