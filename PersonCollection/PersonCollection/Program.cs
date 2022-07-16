//SortedList insertion operation and removal operation take O(n).
//Removes the person object with the maximum value and returns it performed in WC time complexity of O(1).
//SortedList sorted by max value.
//Max value can be determined by diffrent stratagies based on some IPerson properties.

using PersonCollection;
var maximumValueSortStrategy = new MaximumValueSortStrategyByPersonId();
var personCollection = new PersonSortedCollection(maximumValueSortStrategy);