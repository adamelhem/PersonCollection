namespace PersonCollection
{
    public class PersonCollection
    {

        IStrategyPersonCollection _strategyPersonCollection;

        public PersonCollection(IStrategyPersonCollection strategyPersonCollection)
        {
            _strategyPersonCollection = strategyPersonCollection;
        }

        public void Add(IPerson person) => _strategyPersonCollection.Add(person);
        public void Remove(IPerson person) => _strategyPersonCollection.Remove(person);
        public void Publish(IPerson person) => _strategyPersonCollection.Publish(person);

    }
}