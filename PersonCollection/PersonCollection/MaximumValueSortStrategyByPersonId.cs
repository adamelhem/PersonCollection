namespace PersonCollection
{
    public class MaximumValueSortStrategyByPersonId : MaximumValueSortIndexer
    {
        public override int GetIndexKey(IPerson? x) => (x == null) ? 0 : x.getId();
    }
}