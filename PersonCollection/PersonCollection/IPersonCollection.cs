namespace PersonCollection
{
    public interface IPersonCollection
    {
        public void Add(IPerson person);
        public IPerson Remove(IPerson person);
        public void Publish(IPerson person);
    }
}