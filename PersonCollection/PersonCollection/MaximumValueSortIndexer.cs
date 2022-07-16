using System.Collections;

namespace PersonCollection
{
    public abstract class MaximumValueSortIndexer: IComparer<int>
    {
        public virtual int Compare(int x, int y) => x-y;
        public abstract int GetIndexKey(IPerson? x);
    }
}