namespace PersonCollection
{
    public class Strategy1PersonCollection : IStrategyPersonCollection
    {
        SortedList<int, IPerson> _sortedList;
        MaximumValueSortIndexer _maximumValueSortStrategy;

        public Strategy1PersonCollection(MaximumValueSortIndexer maximumValueSortStrategy)
        {
            _sortedList = new SortedList<int, IPerson>(maximumValueSortStrategy);
            _maximumValueSortStrategy = maximumValueSortStrategy;
        }

        public void Add(IPerson person)
        {
            var index = _maximumValueSortStrategy.GetIndexKey(person);
            _sortedList.Add(index,person);
        }

        public IPerson Remove(IPerson person)
        {
            var personWithMaxVal = _sortedList.Values.Last();
            _sortedList.RemoveAt(_sortedList.Count -1);
            return personWithMaxVal;
        }

        public void Publish(IPerson person)
        {
            throw new NotImplementedException();
        }

    }
}