// See https://aka.ms/new-console-template for more information
using PersonCollection;

Console.WriteLine("Hello, World!");
var maximumValueSortStrategy = new MaximumValueSortStrategyByPersonId();
var personCollection = new Strategy1PersonCollection(maximumValueSortStrategy);