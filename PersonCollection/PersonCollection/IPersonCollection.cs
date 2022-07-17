namespace PersonCollection
{
    public interface IPersonCollection: IPersonTracker
    {
        public void Add(IPerson person);
        public IPerson Remove(IPerson person);
        public void PublishTrack(IPerson person) { }
    }
}