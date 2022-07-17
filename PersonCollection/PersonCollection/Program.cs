//https://github.com/adamelhem/PersonCollection.git
//SortedList insertion operation and removal operation take O(n).
//Removes the person object with the maximum value and returns it performed in WC time complexity of O(1).
//SortedList sorted by max value.
//Max value can be determined by diffrent stratagies based on some IPerson properties.

using PersonCollection;
var maximumValueSortStrategy = new MaximumValueSortStrategyByPersonId();
var personCollectionTracker = new PersonSortedCollection(maximumValueSortStrategy);

var reporter1 = new Reporter("reporter1");
var reporter2 = new Reporter("reporter2");
var reporter3 = new Reporter("reporter3");

reporter1.Subscribe(personCollectionTracker);
reporter2.Subscribe(personCollectionTracker);
reporter3.Subscribe(personCollectionTracker);

personCollectionTracker.Add(new Person(DateTime.Now,"Adam",170,0,"melhem"));
personCollectionTracker.Add(new Person(DateTime.Now, "Adam1", 171, 1, "melhem1"));
personCollectionTracker.Add(new Person(DateTime.Now, "Adam2", 172, 2, "melhem2"));

personCollectionTracker.EndTransmission();