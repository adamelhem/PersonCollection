//https://github.com/adamelhem/PersonCollection.git
//SortedList insertion operation and removal operation take O(n).
//Removes the person object with the maximum value and returns it performed in WC time complexity of O(1).
//SortedList sorted by max value.
//Max value can be determined by diffrent stratagies based on some IPerson properties.

using PersonCollection;
using System.Diagnostics;

public class Reporter : IReporter
{
    private IDisposable unsubscriber;
    private string _instName;

    public Reporter(string name)
    {
        _instName = name;
    }

    public string Name => _instName;

    public virtual void Subscribe(IObservable<IPerson> provider)
    {
        if (provider != null)
        {
            unsubscriber = provider.Subscribe(this);
        }
    }

    public virtual void OnCompleted()
    {        
        Debug.WriteLine($"The Tracker has completed transmitting data to _instName:{_instName}");
        this.Unsubscribe();
    }

    public virtual void OnError(Exception e) =>
        Debug.WriteLine($"error occuried at _instName:{_instName}");

    public virtual void OnNext(IPerson value) =>
        Debug.WriteLine($"_instName:{_instName}: ack the added Iperson with id {value.getId()}");

    public virtual void Unsubscribe()
    {
        unsubscriber.Dispose();
    }

}