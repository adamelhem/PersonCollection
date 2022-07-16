namespace PersonCollection
{
    public class PersonCollection
    {

        IPersonCollection _strategyPersonCollection;

        public PersonCollection(IPersonCollection strategyPersonCollection)
        {
            _strategyPersonCollection = strategyPersonCollection;
        }

        public void Add(IPerson person) => _strategyPersonCollection.Add(person);
        public void Remove(IPerson person) => _strategyPersonCollection.Remove(person);
        public void Publish(IPerson person) => _strategyPersonCollection.Publish(person);

    }
}