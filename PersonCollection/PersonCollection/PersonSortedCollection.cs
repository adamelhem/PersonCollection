namespace PersonCollection
{
    public class PersonSortedCollection : IPersonCollection
    {
        SortedList<int, IPerson> _sortedList;
        MaximumValueSortIndexer _maximumValueSortStrategy;
        List<IObserver<IPerson>> _observers;

        public PersonSortedCollection(MaximumValueSortIndexer maximumValueSortStrategy)
        {
            _sortedList = new SortedList<int, IPerson>(maximumValueSortStrategy);
            _maximumValueSortStrategy = maximumValueSortStrategy;
            _observers = new List<IObserver<IPerson>>();
        }

        public void Add(IPerson person)
        {
            var index = _maximumValueSortStrategy.GetIndexKey(person);
            _sortedList.Add(index,person);
            PublishTrack(person);
        }

        public IPerson Remove(IPerson person)
        {
            var personWithMaxVal = _sortedList.Values.Last();
            _sortedList.RemoveAt(_sortedList.Count -1);
            return personWithMaxVal;
        }

        public IDisposable Subscribe(IObserver<IPerson> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubscriber(_observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<IPerson>> _observers;
            private IObserver<IPerson> _observer;

            public Unsubscriber(List<IObserver<IPerson>> observers, IObserver<IPerson> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        void PublishTrack(IPerson person)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(person);
            }
        }

        public void EndTransmission()
        {
            foreach (var observer in _observers.ToArray())
                if (_observers.Contains(observer))
                {
                    observer.OnCompleted();
                }
            _observers.Clear();
        }

    }
}