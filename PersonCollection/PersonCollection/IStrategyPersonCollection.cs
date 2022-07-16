namespace PersonCollection
{
    public interface IStrategyPersonCollection
    {
        public void Add(IPerson person);
        public IPerson Remove(IPerson person);
        public void Publish(IPerson person);
    }
}